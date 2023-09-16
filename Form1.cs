using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;

namespace Juky_Shortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("User32.dll")]
        static extern bool SetForegroundWindow(IntPtr point);
        public void sendMsg(string melding)
        {
            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (process.ProcessName.Contains("s3client") == true)
                {
                    int id = process.Id;

                    Process p = Process.GetProcessById(id);
                    if (p != null)
                    {
                        IntPtr h = p.MainWindowHandle;
                        SetForegroundWindow(h);
                        AutomationElement element = AutomationElement.FromHandle(process.MainWindowHandle);
                        if (element != null)
                        {
                            element.SetFocus();
                        }
                   
                        SendKeys.SendWait("."+melding);
                        SendKeys.Send("{ENTER}");
                       
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendMsg("think you do");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendMsg("mop mop");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendMsg("Cyka byat");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sendMsg("disappointed");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sendMsg("disastah");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sendMsg("Do it");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sendMsg("dont stop me now");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            sendMsg("dots");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sendMsg("dun dun dun");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sendMsg("ehm");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sendMsg("fuuuuuk");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sendMsg("gift for you");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sendMsg("girls are stupid");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sendMsg("got a nice tip for you");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sendMsg("got intro");
        }

        private void button63_Click(object sender, EventArgs e)
        {
            sendMsg("great a former member");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            sendMsg("guess who");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sendMsg("Guess whos back");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sendMsg("hasta la vista");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sendMsg("he he he");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sendMsg("he will join us");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sendMsg("hefty");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sendMsg("help me beat");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            sendMsg("here comes jesus");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            sendMsg("how do you feel about computers");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            sendMsg("how good you you to join us");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            sendMsg("i must obey");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            sendMsg("im a tumor");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            sendMsg("im retarded");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            sendMsg("is that that now");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            sendMsg("jacob");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            sendMsg("JUST DO IT");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            sendMsg("JuSt DoIt");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            sendMsg("keem");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            sendMsg("lets get into the news");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            sendMsg("level up");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            sendMsg("loloh");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            sendMsg("look who we have here");
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            sendMsg("magic missile");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            sendMsg("make my heart go");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            sendMsg("make you dreams come true");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            sendMsg("never gona");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            sendMsg("okie doky");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            sendMsg("pointless to resist");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            sendMsg("ready to work");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            sendMsg("potato");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            sendMsg("sad");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            sendMsg("scall");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            sendMsg("slap you right on");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            sendMsg("smsg");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            sendMsg("something need doing");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            sendMsg("spiderpig");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            sendMsg("that question will be answered");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            sendMsg("they dont know what they are doing");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            sendMsg("time of my life");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            sendMsg("time to work");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            sendMsg("waow");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            sendMsg("we did it we are the best");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            sendMsg("we need more gold");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            sendMsg("We really haft to get going");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            sendMsg("what are u waiting for");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            sendMsg("what are you");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            sendMsg("what is going on here");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            sendMsg("what is going on in my pants");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            sendMsg("where is the paperboy");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            sendMsg("whos your daddy");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            sendMsg("work work work");
        }

        private void button68_Click(object sender, EventArgs e)
        {
            sendMsg("yeserday you said tomorrow");
        }

        private void button67_Click(object sender, EventArgs e)
        {
            sendMsg("you are not nice");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            sendMsg("you are not very good");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            sendMsg("you dont fear death");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            sendMsg("you have aids");
        }

        private void button79_Click(object sender, EventArgs e)
        {
            sendMsg("you should get to the point");
        }

        private void button78_Click(object sender, EventArgs e)
        {
            sendMsg("youre shit");
        }
        private void button74_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
