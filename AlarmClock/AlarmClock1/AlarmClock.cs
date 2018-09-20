using System;

namespace AlarmClock1
{
    //class AlarmClock
    //{
    //    public event EventHandler OnAlarm;

    //    public void FireAlarm()
    //    {
    //        var alarmer = OnAlarm as EventHandler;
    //        var dels = alarmer.GetInvocationList();
    //        foreach (var del in dels)
    //        {
    //            del.DynamicInvoke(this, new EventArgs { });
    //        }
    //        alarmer.Invoke(this, new EventArgs { });
    //        alarmer(new { }, new EventArgs { });
    //    }
    //}

    class AlarmClock
    {
        public delegate void OnAlarm(object o, EventArgs e);
        OnAlarm alarmer;

        public void FireAlarm()
        {
            
            alarmer(this, new EventArgs { });
        }

        public void AddSleeper(OnAlarm a)
        {
            alarmer = new OnAlarm(a);            
        }
       
    }
}
