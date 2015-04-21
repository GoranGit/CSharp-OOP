namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;
    public class Chair : Furniture, IChair, IFurniture
    {
        public int numberOfLegs;

        public Chair(string model, decimal price, decimal height, string material, int numberOfLegs)
            : base(model, price, height, material)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            protected set
            {
                if (value < 1)
                    throw new ArgumentException("Chair can't have less than 1 legs!");
                else
                    this.numberOfLegs = value;
            }

        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", Legs: {0}",this.NumberOfLegs);
        }
    }
}
