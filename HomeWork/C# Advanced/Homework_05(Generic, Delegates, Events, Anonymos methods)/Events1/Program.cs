using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Events1
{
    /* The goal is to log in console and in file on every passed second 
     
        1. Define delegate into the publisher (signature method)
        2. Define event into the publisher
        3. Raise or publish the event
     */
  
    public class Clock
    {
        private int _hour = -1;
        private int _minute = -1;
        private int _second = -1;

        public delegate void SecondChangeHandler(object clock, TimeInfoEventArgs timeInformation);
        public event SecondChangeHandler SecondsChange;
        
        //public delegate void MinuteChangeHandler(object clock, TimeInfoEventArgs timeInformation);
        //public event MinuteChangeHandler MinuteChange;
        public event EventHandler<TimeInfoEventArgs> MinuteChange; // newer version of c#

        public delegate void SecondChangeHandler1(object source, EventArgs arg);
        public event SecondChangeHandler1 SecondsChange1;


        protected void OnSecondChange(object clock, TimeInfoEventArgs timeInformation)
        {
            if (SecondsChange != null)
            {
                SecondsChange(clock, timeInformation);
            }
        }

        protected void OnMinuteChange (TimeInfoEventArgs timeInformation)
        {
            if (MinuteChange != null)
            {
                MinuteChange(this, timeInformation);
            }
        }

        protected void OnSecondsChange1()
        {
            if (SecondsChange1 != null)
            {
                SecondsChange1(this, EventArgs.Empty);
            }
        }

        public void Run()
        {
            do
            {
                Thread.Sleep(1000);
                System.DateTime dt = System.DateTime.Now;

              

                if (dt.Second != _second)
                {
                    TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
                    OnSecondChange(this, timeInformation);
                    OnSecondsChange1();
                }

                if ((dt.Minute != _minute) && (_minute != -1))
                {
                    TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);
                    OnMinuteChange(timeInformation);
                }

                _second = dt.Second;
                _minute = dt.Minute;
                _hour = dt.Hour;

            } while (true);
        }
    }

    public class TimeInfoEventArgs : EventArgs
    {
        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public readonly int hour;
        public readonly int minute;
        public readonly int second;
    }

    public class DisplayClock
    {
        public void WriteTime(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Current Time: {0}:{1}:{2}",
               ti.hour.ToString(),
               ti.minute.ToString(),
               ti.second.ToString());
        }

        public void WriteOnFullMinute(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Full minute!!");
        }
    }
    
    public class LogClock
    {
        public void WriteLogEntry(object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Logging to file: {0}:{1}:{2}",
               ti.hour.ToString(),
               ti.minute.ToString(),
               ti.second.ToString());
        }

        public void WriteHelloEvent(object theClock, EventArgs args)
        {
            Console.WriteLine("Hello Event onSecondsChange1");
        }

        public void Subscribe (Clock clock)
        {
            clock.SecondsChange1 += new Clock.SecondChangeHandler1(WriteHelloEvent);
        }
    }
    
    public class Program
    {
        public static void Main()
        {
            Clock theClock = new Clock();
            DisplayClock displayClock = new DisplayClock();
            LogClock lc = new LogClock();

            theClock.SecondsChange += displayClock.WriteTime;
            theClock.MinuteChange += displayClock.WriteOnFullMinute;
            theClock.SecondsChange1 += delegate { Console.WriteLine("Anonymous Methods from delegate"); };

            theClock.SecondsChange += lc.WriteLogEntry;
            lc.Subscribe(theClock);

            theClock.Run();

            Console.ReadLine();
        }
    }
}