namespace _01DefineClass
{
    using System;
    using System.Collections.Generic;
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private static string iPhone4S;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.battery = new Battery("Made In China!");
            this.display = new Display(5.7, 16000000);
        }
        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public static string IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Display DisplayProp
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Model:{0} \n Manufacturer:{1} \n Price:{2} \n Owner:{3} \n Battery:{4} \n Display:{5}", this.model, this.manufacturer, this.price, this.owner, this.battery.ToString(), this.display.ToString());
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }
        public double CalcCallPrice(double callPrice)
        {          
            double sumSec = 0;
            foreach(Call k in this.callHistory)
            {
                sumSec += k.Duration;
            }
            return (sumSec / 60) * callPrice;
        }

    }
}
