using NFA_RCOM;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using Monitoring.Model;
using Monitoring.View;
using System.Windows.Forms;
using System.Xml.Linq;

// 서비스이벤트 후 정상화 시 Fault 상태 변경 코드 필요
namespace Monitoring.Controller
{
    public class MainController
    {
        public enum STATE
        {
            CREATE,
            CONNECT,
            GETDATA,
            PROCESSDATA,
            CONNECTERROR,
            DISCONNECT
        }
        const int max_time = 60;    // Fault CountDown Time (Seconds)
        private NFA_RCOM.clsRCOM _RCOM;
        private View.MainView _MainView;
        private IList<Battery> _batList;
        private Option _option;

        public MainController(View.MainView view) 
        {
            bool isSMS = Properties.Settings.Default._isSMS;
            bool isReboot = Properties.Settings.Default._isReboot;
            _option = new Option(isSMS, isReboot);  // Program Properties Setting에 저장된 값으로 CMD 설정
            _batList = new List<Battery>();
            _MainView = view;
            _MainView.SetController(this);  // View 컨트롤러 설정
            _MainView.UpdateServiceView(_option); // View CMD 체크 설정

            clsLog.uploadLog += new EventHandler(UpdateLog);    // Event (Log to View UI)

            Task.Run(() => RunState());  // State Machine
        
            _MainView.ShowDialog();
        }

        public bool ReadData() 
        {
            Dictionary<string, clsDevice> dic = new Dictionary<string, clsDevice>();
            try
            {
                dic = _RCOM.getDeviceList();

                foreach (KeyValuePair<string, clsDevice> dv in dic)
                {
                    string deviceName = dv.Value.DeviceName;

                    if (deviceName.Contains("배터리") && !deviceName.Contains("RACK"))
                    {
                        Dictionary<string, clsPacket> dicPK = dv.Value.PacketList;
                        foreach (KeyValuePair<string, clsPacket> pk in dicPK)
                        {
                            string packet = pk.Value.PacketID;

                            Dictionary<string, clsTag> dicTg = pk.Value.TagList;
                            UpdateBatListValue(deviceName, dicTg);  // 배터리 상태 갱신
                        }
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public void InitBatListValue()
        {
            //_batList.Clear();
            foreach(var bat in _batList)
            {
                bat.SOC = 0;
                bat.Current = 0;
                bat.Fault = false;
            }
        }

        public void UpdateBatListValue(string deviceName, Dictionary<string, clsTag> Tag)
        {
            // INSERT BATTERY DEVICE
            bool hasBat = false;
            
            foreach (Battery bat in _batList)
            {
                if (bat.Name == deviceName)
                    hasBat = true;
            }

            if(!hasBat)
            {
                Battery bat = new Battery(deviceName);
                _batList.Add(bat);
                _MainView.AddBatView(bat);
            }

            // UPDATE BATTERY DATA
            try
            {
                foreach (var bat in _batList)
                {
                    if (bat.Name == deviceName)
                    {
                        foreach (KeyValuePair<string, clsTag> tmp in Tag)
                        {
                            clsTag _tag = tmp.Value;

                            if (_tag.TagID == null || _tag.TagValue == null)
                                break;

                            string strTagID = _tag.TagID;
                            string strTagValue = _tag.TagValue;

                            if (strTagID == "Bat_Current")
                            {
                                bat.Current = strTagValue == null ? int.Parse("0") : int.Parse(strTagValue);
                            }

                            if (strTagID == "Bat_SOC")
                            {
                                bat.SOC = strTagValue == null ? double.Parse("0") : double.Parse(strTagValue);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace.ToString());
            }
        }

        public void UpdateBatList() 
        {
            if (_batList.Count <= 0) return;

            foreach(Battery bat in _batList)
            {
                _MainView.UpdateBatView(bat);   // 배터리 상태 표시 (to View)
            }
        }

        public void UpdateCMD(Option cmd) 
        {
            _option = cmd;

            // 체크박스 상태 저장
            Properties.Settings.Default._isSMS = _option.SMS;
            Properties.Settings.Default._isReboot = _option.Reboot;
            Properties.Settings.Default.Save();
        }

        public void UpdateLog(string strlog) 
        {
            string log = strlog;
            _MainView.UpdateLogView(log);   // 로그 표시 (to View)
        }

        public void CheckBatFalut()
        {
            foreach(var bat in _batList) 
            {
                // 조건 = Bat Current < 0, SCO < 0, Fault 진행 아닐 시
                if (bat.Current < 0 && bat.SOC <= 0 && bat.Fault == false)
                {
                    bat.Fault = true;
                    string deviceName = bat.Name;
                    Task.Run(() => CheckBatFaultCount(deviceName));  // Fault 카운트 시작
                }
            }
        }
        
        public void CheckBatFaultCount(object name) 
        {
            string _name = name.ToString();
            DateTime end_time = DateTime.Now.AddSeconds(max_time);
            
            UpdateLog($"{_name} Error Count Start");
            
            while (true)
            {
                foreach(var _bat in _batList)
                {
                    // Fault 배터리 체크
                    if(_bat.Name == _name)
                    {
                        // 값 지속 확인
                        if (_bat.SOC <= 0 && _bat.Current < 0)
                        {
                            // max_time 이후 값 정상 아닐 시 통신프로그램 종료 및 SMS 송신
                            if (end_time < DateTime.Now)
                            {
                                RunCMD(_name);
                                return;
                            }
                        }
                        else
                        {
                            _bat.Fault = false;
                            UpdateLog($"{_name} Error Count Cancel");
                            return;
                        }
                    }
                }
                Thread.Sleep(1000);
            }
        }

        public void RunCMD(object name)
        {
            string _name = name.ToString();

            // exec Service - SMS, Reboot
            if (_option.SMS)
            {
                //SMS Send
                UpdateLog($"{_name} Send SMS");
            }

            if (_option.Reboot)
            {
                clsProcess.RebootProcess("NFA");
                clsProcess.RebootProcess("NFA_HOST");
                UpdateLog($"{_name} Reboot NFA");
            }
        }

        public void RunState()
        {
            STATE state = STATE.CREATE;
            int count = 0;

            while (true)
            {
                switch (state)
                {
                    case STATE.CREATE:
                        if(_RCOM != null)
                        {
                            _RCOM = null;
                        }
                        else
                        {
                            _RCOM = new clsRCOM();
                            state = STATE.CONNECT;
                        }

                        count = 0;

                        break;

                    case STATE.CONNECT:
                        try 
                        { 
                            _RCOM.getAllInfo(); // 연결확인용
                            state = STATE.GETDATA;
                        }
                        catch 
                        {
                            state = STATE.CONNECTERROR;
                        }
                        
                        break;

                    case STATE.GETDATA:
                        if(ReadData())
                        {
                            state = STATE.PROCESSDATA;
                        }
                        else
                        {
                            state = STATE.CONNECTERROR;
                        }
                        
                        break;

                    case STATE.PROCESSDATA:
                        UpdateBatList();    // 배터리 상태 업데이트 (to View)
                        CheckBatFalut();    // 배터리 상태이상 확인
                        
                        state = STATE.GETDATA;
                        
                        break;

                    case STATE.CONNECTERROR:
                        if (count < 0)     // 사용안함, 바로 Disconnect 
                        {
                            count++;
                            state = STATE.CONNECT;
                        }
                        else
                        {
                            state = STATE.DISCONNECT;
                        }
                        
                        break;

                    case STATE.DISCONNECT:
                        if(_RCOM != null)
                        {
                            _RCOM = null;
                        }

                        state = STATE.CREATE;

                        break;
                }

                _MainView.UpdateConnectionView(state);  // 상태 표시 (to View)
            }
        }
    }
}
