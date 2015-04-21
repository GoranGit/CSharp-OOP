namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, ITable, IFurniture
    {
        private decimal length;
        private decimal width;

        public Table(string model, decimal price, decimal height, string material, decimal length, decimal width)
            : base(model, price, height, material)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Lenght of table can't be  0 or negative!");
                else
                    this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Width of table can't be  0 or negative!");
                else
                    this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public override string ToString()
        {
            return    base.ToString() + String.Format(", Length: {0}, Width: {1}, Area: {2}",this.Length,this.Width,this.Area);
        }
    }
}
