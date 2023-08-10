using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NFA_RCOM;
using Monitoring.Controller;
using Monitoring.Model;
using Monitoring.View;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.IO;
using System.Reflection;

namespace Monitoring
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(ResolveAssembly);
            RemotingConfiguration.Configure("Monitoring.exe.config", false);
            MainView mainView = new MainView();
            MainController control = new MainController(mainView);
        }

        static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            var name = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";

            var resources = thisAssembly.GetManifestResourceNames().Where(s => s.EndsWith(name));
            if (resources.Count() > 0)
            {
                string resourceName = resources.First();
                using (Stream stream = thisAssembly.GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        byte[] assembly = new byte[stream.Length];
                        stream.Read(assembly, 0, assembly.Length);
                        Console.WriteLine("Dll file load : " + resourceName);
                        return Assembly.Load(assembly);
                    }
                }
            }
            return null;
        }
    }
}
