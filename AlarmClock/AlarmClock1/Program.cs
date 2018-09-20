using System;

namespace AlarmClock1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock();
            AlarmClock.OnAlarm alarmer = Clock_OnAlarm;
            clock.AddSleeper(alarmer);            
            clock.FireAlarm();
            
        }

        private static void Clock_OnAlarm(object sender, EventArgs e)
        {
            Console.WriteLine("Alarm fired");
        }
    }
}
