using System;
using System.Collections.Generic;
using System.Text;

namespace Shutdown_Timer
{

    public class Program_Constants
    {
        public static string mode = "-s"; /* Mode (Shutdown, Restart, Log off) */
        public static bool alarm = false; /* Mode of operation (Countdown or Alarm) */
        public static int hours, mins, secs = 0; /* Raw values as displayed in the GUI */
        public static int c_hours, c_mins, c_secs = 0; /* Modified values used internaly */
        public static int TTD = 0; /* TTD - Raw amount of seconds the countdown should last */
        public static bool running = false; /* Controls if the countdown is running */
        public static bool visible = true; /* Controls counter flashing */
        public static DateTime timeNow = DateTime.Now;
        public static DateTime timeTarget = DateTime.Now;
    }
}
