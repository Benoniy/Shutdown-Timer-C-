using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shutdown_Timer
{
    public partial class Form1 : Form
    {
        private delegate void toggleVisibleDel();
        private delegate void checkValueDel();
        private Thread th;


        public Form1()
        {
            this.CreateHandle();
            this.CreateControl();
            InitializeComponent();
        }

        /* This controls the current mode (Shutdown, Restart, Log off)*/
        private void radioButtonMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonS.Checked)
            {
                Program_Constants.mode = "-s";
            }
            else if (radioButtonR.Checked)
            {
                Program_Constants.mode = "-r";
            }
            else
            {
                Program_Constants.mode = "-l";
            }
        }

        /* This controls whether the timer is countdown based or acts as an alarm*/
        private void radioButtonAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAlarm.Checked)
            {
                Program_Constants.alarm = true;
            }
            else
            {
                Program_Constants.alarm = false;
            }
        }

        /* Disables the ability to alter the timer during operation*/
        private void changeOptions(bool current)
        {
            radioButtonS.Enabled = current;
            radioButtonR.Enabled = current;
            radioButtonL.Enabled = current;

            radioButtonAlarm.Enabled = current;
            radioButtonCount.Enabled = current;
        }

        /* Is run when the start/stop button is pressed*/
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text.Equals("Start"))
            {
                buttonStart.Text = "Stop";
                changeOptions(false);
                Program_Constants.running = true;
                th = new Thread(new ThreadStart(runTimer));
                th.Start();
            }
            else
            {
                th.Abort();
                buttonStart.Text = "Start";
                changeOptions(true);
                Program_Constants.running = false;
                Program_Constants.visible = true;
                labelHours.Visible = true;
                labelMins.Visible = true;
                labelSecs.Visible = true;
            }
        }

        /* This is run whenever a time value is changed */
        private void valueChange(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Name)
            {
                case "buttonHoursUp_BIG":
                    Program_Constants.hours += 10;
                    break;

                case "buttonHoursUp":
                    Program_Constants.hours += 1;
                    break;

                case "buttonHoursDown_BIG":
                    Program_Constants.hours -= 10;
                    break;

                case "buttonHoursDown":
                    Program_Constants.hours -= 1;
                    break;

                case "buttonMinsUp_BIG":
                    Program_Constants.mins += 10;
                    break;

                case "buttonMinsUp":
                    Program_Constants.mins += 1;
                    break;

                case "buttonMinsDown_BIG":
                    Program_Constants.mins -= 10;
                    break;

                case "buttonMinsDown":
                    Program_Constants.mins -= 1;
                    break;

                case "buttonSecsUp_BIG":
                    Program_Constants.secs += 10;
                    break;

                case "buttonSecsUp":
                    Program_Constants.secs += 1;
                    break;

                case "buttonSecsDown_BIG":
                    Program_Constants.secs -= 10;
                    break;

                case "buttonSecsDown":
                    Program_Constants.secs -= 1;
                    break;
            }

            checkValue();
            AdjustUiVals();
        }

        private void checkValue()
        {
            int hours, mins, secs;
            hours = Program_Constants.hours;
            mins = Program_Constants.mins;
            secs = Program_Constants.secs;

            if (secs > 59)
            {
                secs = 0;
                mins += 1;
            }

            if (mins > 59)
            {
                mins = 0;
                hours += 1;
            }

            if (hours > 23)
            {
                hours = 23;
                mins = 59;
                secs = 59;
            }

            if (secs < 0)
            {
                secs = 59;
                mins -= 1;
            }

            if (mins < 0)
            {
                mins = 59;
                hours -= 1;
            }

            if (hours < 0)
            {
                hours = 0;
                mins = 0;
                secs = 0;
            }

            Program_Constants.hours = hours;
            Program_Constants.mins = mins;
            Program_Constants.secs = secs;

            /* allows the values to adjust until it starts for alarm mode */
            if (!Program_Constants.running)
            {
                Program_Constants.c_hours = hours;
                Program_Constants.c_mins = mins;
                Program_Constants.c_secs = secs;
            }
        }

        private void AdjustUiVals()
        {
            /* String label formating */
            string hlb = Program_Constants.hours.ToString();
            if (hlb.Length == 1) { hlb = "0" + hlb; }
            string mlb = Program_Constants.mins.ToString();
            if (mlb.Length == 1) { mlb = "0" + mlb; }
            string slb = Program_Constants.secs.ToString();
            if (slb.Length == 1) { slb = "0" + slb; }
            labelHours.Text = hlb;
            labelMins.Text = mlb;
            labelSecs.Text = slb;
        }

        private void runCommand()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -t 0 " + Program_Constants.mode;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void toggleLabels()
        {
            labelHours.Visible = !labelHours.Visible;
            labelMins.Visible = labelHours.Visible;
            labelSecs.Visible = labelHours.Visible;
            labelColon1.Visible = labelHours.Visible;
            labelColon2.Visible = labelHours.Visible;
        }

        public void runTimer()
        {
            try
            {
                while (Program_Constants.running)
                {

                    groupBox3.Invoke(new toggleVisibleDel(countdown));
                    Thread.Sleep(750);
                    if (Program_Constants.alarm)
                    {
                        groupBox3.Invoke(new toggleVisibleDel(toggleLabels));
                    }
                    Thread.Sleep(250);
                    if (Program_Constants.alarm)
                    {
                        groupBox3.Invoke(new toggleVisibleDel(toggleLabels));
                    }
                }
            }
            catch
            {
                th.Abort();
                Program_Constants.running = false;
            }
            
        }

        /* counts down until H, M, S are all 0*/
        public void countdown()
        {
            

            if (!Program_Constants.alarm)
            {
                Program_Constants.secs -= 1;
                checkValue();
                AdjustUiVals();

                /* When all values reach 0 the command is run */
                if (Program_Constants.hours == 0 & Program_Constants.mins == 0 & Program_Constants.secs == 0 & Program_Constants.running)
                {
                    runCommand();
                }
            }
            else
            {
                Program_Constants.timeNow = DateTime.Now;
                if (Program_Constants.timeNow.Hour == Program_Constants.c_hours && Program_Constants.timeNow.Minute == Program_Constants.c_mins && Program_Constants.timeNow.Second >= Program_Constants.c_secs)
                {
                    runCommand();
                }
            }
            
        }
    }
}

