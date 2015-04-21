
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair,IChair,IFurniture
    {
        public readonly decimal InitialHeight; 

        public ConvertibleChair(string model, decimal price, decimal height, string material, int numberOfLegs):base(model, price, height, material, numberOfLegs)
        {
            this.IsConverted = false; //initial state is normal
            this.InitialHeight = height;
        }

        public bool IsConverted
        {
            get;
            private set;
        }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
            if (this.IsConverted)
                this.Height = 0.10m;
            else
                this.Height = this.InitialHeight;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
