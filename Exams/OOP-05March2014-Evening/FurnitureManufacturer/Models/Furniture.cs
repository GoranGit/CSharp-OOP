namespace FurnitureManufacturer.Models
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Furniture : FurnitureManufacturer.Interfaces.IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public Furniture(string model,decimal price,decimal height,string material)
        {
            this.Model = model;
            this.Price = price;
            this.Height = height;
            this.Material = material;
        }

        public string Model
        {
            get 
            {
                return this.model;    
            }
            protected set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3)
                    throw new ArgumentException("Model  property can't be  null, empty or less than 3 simbols!");
                else
                    this.model = value;
            }
        }

        public string Material
        {
            get;
            protected set;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price can't be  less or equal to 0!");
                else
                    this.price = value;
            }
        }

        public decimal Height
        {
            get 
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Price can't be  less or equal to 0!");
                else
                    this.height = value;
            }
        }

        public override bool Equals(Object o)
        {
            Furniture obj = (Furniture)o;
            return object.Equals(this.Model,obj.Model) && this.Price == obj.Price && this.Height == obj.Height && object.Equals(this.Material,obj.Material);
        }

        public override string ToString()
        {
            return String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model,this.Material, this.Price, this.Height);
        }
    }
}
