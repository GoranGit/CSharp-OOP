
namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Company : FurnitureManufacturer.Interfaces.ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string regNumber)
        {
            this.Name = name;
            this.RegistrationNumber = regNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 5)
                    throw new ArgumentException("Name  can't  be less than 5 simbols!");
                else
                    this.name = value;
            }

        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {
                if (value!=null && value.All(x => char.IsDigit(x)) && value.Length == 10)
                {
                    this.registrationNumber = value;
                }
                else
                    throw new ArgumentException("Incorect registration number!");
            }
        }

        public ICollection<Interfaces.IFurniture> Furnitures
        {
            get 
            {
                return this.furnitures;
            }
        }

        public void Add(Interfaces.IFurniture furniture)
        {
            this.furnitures.Add(furniture);
            this.furnitures = this.furnitures.OrderBy(x => x.Price).ThenBy(y => y.Model).ToList();
        }

        public void Remove(Interfaces.IFurniture furniture)
        {
            IFurniture delete = furnitures.FirstOrDefault(x => x.Equals(furniture));
            this.furnitures.Remove(delete);
        }

        public IFurniture Find(string model)
        {
            string mod = model.ToLower();
            var k = furnitures.FirstOrDefault(x => x.Model.ToLower().Equals(mod));
            return k;
        }

        public string Catalog()
        {
            StringBuilder result = new StringBuilder(String.Format("{0} - {1} - {2} {3}",
                                this.Name,
                                this.RegistrationNumber,
                                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            foreach(var furniture in furnitures)
            {
                result.Append("\n");
                result.Append(furniture.ToString());
            }
            return result.ToString();
        }
    }
}
