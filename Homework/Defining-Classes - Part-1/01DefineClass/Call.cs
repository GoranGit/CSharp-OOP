namespace _01DefineClass
{
    using System;
    public class Call
    {
        private DateTime dateTime;
        private string dialledPhoneNumber;
        private int duration;

        public Call(DateTime dateTime, string dialledPhoneNumber, int durationSec)
        {
            this.dateTime = dateTime;
            this.dialledPhoneNumber = dialledPhoneNumber;
            this.duration = durationSec;

        }

        public DateTime DateAndTime
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }
        public string DialledPhoneNum
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            set
            {
                this.dialledPhoneNumber = value;
            }
        }
        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Date and time:{0}, Called to:{1} Duration:{2}", this.dateTime, this.dialledPhoneNumber, this.duration);
        }
    }
}
