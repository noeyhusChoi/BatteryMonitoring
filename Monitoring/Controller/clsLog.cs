using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Monitoring.Controller
{
    public delegate void EventHandler(string msg);

    public class clsLog
    {
        public static event EventHandler uploadLog;

        private static string _log;

        public static string Log
        {
            get { return _log; }
            set 
            {
                string site = Properties.Settings.Default._site.ToString();
                _log = String.Format($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mmm:ss")}] [{site}] [{value}]"); 
            }
        }

        public static string LogToConsole(string log)
        {
            Log = log;
            Console.WriteLine(_log);
            
            return _log;
        }

        public static string LogToFile(string log)
        {
            Log = log;
            DateTime dateTime = DateTime.Now;
            string path = System.Windows.Forms.Application.StartupPath;
            string dir = "Logs";
            string file = dateTime.ToString("yyyy-MM-dd") + ".txt";

            string dirpath = Path.Combine(path, dir);
            string filepath = Path.Combine(dirpath, file);

            // 폴더 체크
            if (!Directory.Exists(dirpath))
                Directory.CreateDirectory(dirpath);

            StreamWriter writer = new StreamWriter(filepath, append: true);

            writer.WriteLine(_log);
            writer.Close();

            return _log;
        }

        public static string LogToAll(string log)
        {
            Log = log;
            DateTime dateTime = DateTime.Now;
            string path = System.Windows.Forms.Application.StartupPath;
            string dir = "Logs";
            string file = dateTime.ToString("yyyy-MM-dd") + ".txt";

            string dirpath = Path.Combine(path, dir);
            string filepath = Path.Combine(dirpath, file);

            // 폴더 체크
            if (!Directory.Exists(dirpath))
                Directory.CreateDirectory(dirpath);
         
            StreamWriter writer = new StreamWriter(filepath, append:true);
            
            writer.WriteLine(_log);
            writer.Close();

            Console.WriteLine(_log);
            uploadLog(_log);

            return _log;
        }
    }
}
