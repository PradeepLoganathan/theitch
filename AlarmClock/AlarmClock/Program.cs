using System;

namespace AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock SeikoT1 = new Clock();
            

            SeikoT1.AlarmEvent += (s, e) => Console.WriteLine($"Seiko T1 raised an alarm {e.AlarmName} for {e.Hour,-3} hours and {e.Minute,-3} minutes");
            SeikoT1.AlarmEvent += (s, e) => Console.WriteLine($"Seiko T2 raised an alarm {e.AlarmName} for {e.Hour,-3} hours and {e.Minute,-3} minutes");
            SeikoT1.AlarmEvent += (s, e) => Console.WriteLine($"Seiko T3 raised an alarm {e.AlarmName} for {e.Hour,-3} hours and {e.Minute,-3} minutes");

            SeikoT1.WakeUpAlarm();


        }

        
    }
}
