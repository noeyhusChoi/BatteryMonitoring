using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monitoring.Model;
using Monitoring.Controller;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Monitoring.View
{
    public partial class MainView : Form
    {
        private Controller.MainController _control;

        public MainView()
        {
            InitializeComponent();
        }

        public void SetController(Controller.MainController control)
        {
            _control = control;
        }
        public void AddBatView(Bat bat)
        {
            foreach (System.Windows.Forms.Control control in pnlDeviceView.Controls)
            {
                if (control is gridBatBox)
                {
                    gridBatBox tmp = control as gridBatBox;
                    if (tmp.Tag.ToString() == bat.Name) return;
                }
            }

            gridBatBox grid = new gridBatBox();
            grid.Tag = bat.Name;
            grid.Title = bat.Name;
            grid.CenterLeft = "Current";
            grid.CenterRight = "SOC";

            if(pnlDeviceView.InvokeRequired)
            {
                pnlDeviceView.Invoke(new MethodInvoker(delegate { pnlDeviceView.Controls.Add(grid);}));
            }
            else
            {
                pnlDeviceView.Controls.Add(grid);
            }
        }
        public void UpdateBatView(Bat bat)
        {
            // Update Value
            foreach (System.Windows.Forms.Control control in pnlDeviceView.Controls)
            {
                if (control is gridBatBox)
                {
                    gridBatBox tmp = control as gridBatBox;
                    
                    if (tmp.Tag.ToString() == bat.Name)
                    {
                        if (control.InvokeRequired)
                        {
                            tmp.Invoke(new MethodInvoker(delegate
                            {
                                tmp.BottomLeft = string.Format($"{bat.Current}");
                                tmp.BottomRight = string.Format($"{bat.SOC}%");
                            }));
                        }
                        else
                        {
                            tmp.BottomLeft = string.Format($"{bat.Current}");
                            tmp.BottomRight = string.Format($"{bat.SOC}%");
                        }
                    }
                }
            }
        }
        public void UpdateLogView(string log)
        {
            if(richLog.InvokeRequired)
            {
                richLog.Invoke(new MethodInvoker(delegate { richLog.AppendText(log + Environment.NewLine); }));
            }
            else
            {
                richLog.AppendText(log + Environment.NewLine);
            }
        }
        public void UpdateServiceView(CMD service)
        {
            chkSMS.Checked = service.SMS;
            chkReboot.Checked = service.Reboot;
        }
        public void UpdateConnectionView(Controller.MainController.STATE state)
        {
            string strConnection = "";

            switch(state)
            {
                case Controller.MainController.STATE.CREATE:
                    strConnection = "연결 중";
                    break;
                case Controller.MainController.STATE.CONNECT:
                    strConnection = "연결 중";
                    break;
                case Controller.MainController.STATE.GETDATA:
                    strConnection = "통신 중";
                    break;
                case Controller.MainController.STATE.PROCESSDATA:
                    strConnection = "통신 중";
                    break;
                case Controller.MainController.STATE.CONNECTERROR:
                    strConnection = "연결 오류";
                    break;
                case Controller.MainController.STATE.DISCONNECT:
                    strConnection = "연결 끊김";
                    break;
            }

            if(lblConnect.InvokeRequired)
            {
                lblConnect.Invoke(new MethodInvoker(delegate { lblConnect.Text = strConnection; }));
            }
            else
            {
                lblConnect.Text = strConnection;
            }
        }
        public void ShowMessageBox()
        {
            string message = "통신 오류" + Environment.NewLine + "다시 연결 시도하시겠습니까?";

            var result = MessageBox.Show(message, "통신 오류",
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _control.RunState();
            }

        }
        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            bool isSMS = chkSMS.Checked;
            bool isReboot = chkReboot.Checked;

            CMD service = new CMD(isSMS, isReboot);
            _control.UpdateCMD(service);
        }
        private void chkReboot_CheckedChanged(object sender, EventArgs e)
        {
            bool isSMS = chkSMS.Checked;
            bool isReboot = chkReboot.Checked;

            CMD service = new CMD(isSMS, isReboot);
            _control.UpdateCMD(service);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
