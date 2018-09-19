using System;

namespace AlarmClock
{
    public class ClockEventArgs:EventArgs
    {
        public string AlarmName { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
    }
}