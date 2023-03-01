using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AlexRealm
{
    public class Move_icons
    {
        public void move()
        {
            while (true)
            {
                Random rand;
                rand = new Random();
                int x = Screen.PrimaryScreen.Bounds.Width; int y = Screen.PrimaryScreen.Bounds.Height;
                IntPtr handle = dport.FindWindow("Program", null);
                handle = dport.FindWindowEx(handle, IntPtr.Zero, "SHELL_DefView", null);
                handle = dport.FindWindowEx(handle, IntPtr.Zero, "SysListView32", null);
                DirectoryInfo dirinfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                FileInfo[] finfo = dirinfo.GetFiles();
                for (int num = 0; num <= finfo.Length +2; num++)
                {
                    dport.SendMessage(handle, dport.LVM_SETITEMPOSITION, (IntPtr)num, dport.MakeLParam(rand.Next(x), rand.Next(y)));
                    Thread.Sleep(1);
                }
            }
        }
    }
}