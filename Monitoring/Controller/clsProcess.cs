using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Monitoring.Controller
{
    internal class clsProcess
    {
        public clsProcess() { }
        public static List<Process> getProcessList()
        {
            Process[] processes = Process.GetProcesses();

            List<Process> list = processes.ToList();

            return list;
        }
        public static void KillProcess(string ProcessName)
        {
            List<Process> processes = getProcessList();

            foreach (Process process in processes)
            {
                if (process.ProcessName.Equals(ProcessName))
                {
                    process.Kill();
                }
            }
        }
        public static void RebootProcess(string ProcessName)
        {
            List<Process> processes = getProcessList();

            foreach (Process process in processes)
            {
                if (process.ProcessName.Equals(ProcessName))
                {
                    string path = process.MainModule.FileName;
                    
                    process.Kill();

                    Thread.Sleep(1000);

                    if (!IsRunningProcess(ProcessName))
                    {
                        Process.Start(path);    // NFA 에러 => 수정필요 
                    }
                }
            }
        }
        public static bool IsRunningProcess(string ProcessName) 
        {
            var isRunning = Process.GetProcesses().Any(p => p.ProcessName.Equals(ProcessName));

            return isRunning;
        }

    }

    
}
