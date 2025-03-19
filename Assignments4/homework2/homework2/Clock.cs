using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class ClockEventArgs
    {
        public TimeSpan Time { get; set; }
    }
    public delegate void ClockHandler(object sender, ClockEventArgs e);
    public class Clock
    {
        TimeSpan time;
        public TimeSpan alarmTime { get; set; }
        public Clock(int hour, int minute, int second)
        {
            time = new TimeSpan(hour, minute, second);
        }
        
        public event ClockHandler Tick;
        public event ClockHandler Alarm;
        public void Run()
        {
            while (true)
            {
                ClockEventArgs args = new ClockEventArgs()
                {
                    Time = time
                };
                if (time == alarmTime) { Alarm(this, args); }
                Thread.Sleep(1000);
                time=time.Add(new TimeSpan(0,0,1));
                Tick(this, args);
            }
        }
    }
}
