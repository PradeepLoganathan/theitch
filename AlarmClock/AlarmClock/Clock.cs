using System;

namespace AlarmClock
{
    public class Clock
    {
        public event EventHandler<ClockEventArgs> AlarmEvent;
        

        public void WakeUpAlarm()
        {
            (AlarmEvent as EventHandler<ClockEventArgs>)?
                .Invoke(this, new ClockEventArgs() { AlarmName = "Wakeup", Hour = 6, Minute = 30});
        }

       
    }
}
