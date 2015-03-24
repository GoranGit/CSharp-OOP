
namespace DelegateTimer
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    public class Timer
    {
        private int sec;
        private TimerDelegate timerEvent;
        private int ticks;

        public Timer(int sec, int ticks, TimerDelegate timerEvent)
        {
            this.sec = sec;
            this.ticks = ticks;
            this.timerEvent = timerEvent;
        }

        public int Secunds
        {
            get
            {
                return this.sec;
            }
            set
            {
                if (value == 0)
                    throw new TimeoutException("Plaese enter bigger number of seconds than 0!");
                else
                    this.sec = value;
            }
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }
            set
            {
                if (value == 0)
                    throw new TimeoutException("Plaese enter bigger number of ticks than 0!");
                else
                    this.ticks = value;
            }
        }

        public TimerDelegate SubscriberMethod
        {
            get
            {
                return this.timerEvent;
            }
            set
            {
                this.timerEvent = value;
            }
        }

        public void Run()
        {
            while (ticks > 0)
            {
                Thread.Sleep(1000 * sec);
                ticks--;
                SubscriberMethod();
            }

        }

    }
}
