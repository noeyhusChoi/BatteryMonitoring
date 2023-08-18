using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Monitoring.Controller
{
    internal class clsProcess
    {
        public clsProcess() { }
        public static List<Process> GetProcessList()
        {
            Process[] processes = Process.GetProcesses();

            List<Process> list = processes.ToList();

            return list;
        }

        public static void KillProcess(string processname)
        {
            List<Process> processes = GetProcessList();

            try 
            { 
                foreach (Process process in processes)
                {
                    if (process.ProcessName.Equals(processname))
                        process.Kill();
                }
            } 
            catch(Exception e)
            {
                clsLog.LogToFile($"{processname} Shutdown Fail");
                clsLog.LogToFile($"{processname} {e}");
            }
        }

        public static void RebootProcess(string processname)
        {
            List<Process> processes = GetProcessList();

            try
            {
                foreach (Process process in processes)
                {
                    if (process.ProcessName.Equals(processname))
                    {
                        string path = process.MainModule.FileName;
                        
                        process.Kill();

                        Thread.Sleep(1000);

                        if (!IsRunningProcess(processname))
                        {
                            Process startprocess = new Process();
                            startprocess.StartInfo.UseShellExecute = false;
                            startprocess.StartInfo.FileName = path;
                            startprocess.StartInfo.CreateNoWindow = false;
                            startprocess.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);
                            startprocess.Start();

                            clsLog.LogToAll($"{processname} Reboot");
                        }
                    }
                }
            }
            catch(Exception e)
            {
                clsLog.LogToFile($"{processname} Reboot Fail");
                clsLog.LogToFile($"{processname} {e}");
            }
        }

        public static bool IsRunningProcess(string processname) 
        {
            var isRunning = Process.GetProcesses().Any(p => p.ProcessName.Equals(processname));

            return isRunning;
        }
    }
}
