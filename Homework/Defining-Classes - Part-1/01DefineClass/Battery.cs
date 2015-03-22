namespace _01DefineClass
{
    using System;
    public enum BatteryTypeEnum
    {
        Lilon,
        NiMH,
        NiCd
    }

    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryTypeEnum batteryType;

        public Battery(string model)
        {
            this.model = model;
        }
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryTypeEnum batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        public BatteryTypeEnum BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            return String.Format("  Model of battery:{0}, Idle Hours:{1}, Talk Hours:{2},  Battery Type:{3}", this.model, this.hoursIdle, this.hoursTalk, this.batteryType.ToString());
        }

    }
}
