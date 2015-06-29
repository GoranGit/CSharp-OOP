
namespace Cosmetics.Products
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    
    public abstract class Product:IProduct
    {
        private string name;
        private string brand;
        private decimal price;

        public Product(string name,string brand,GenderType genderType,decimal price=0)
        {
            this.Name = name;
            this.Price = price;
            this.Brand = brand;
            this.Gender = genderType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));
                Validator.CheckIfStringLengthIsValid(value, 10, 3, String.Format(GlobalErrorMessages.InvalidStringLength, "Product name",3,10));
                this.name = value;
            }
        }

        public string Brand
        {
            get 
            {
                return this.brand;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product brand"));
                Validator.CheckIfStringLengthIsValid(value, 10, 2, String.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", 2, 10));
                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get 
            {
                return this.price;
            }
            protected set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Price of product can't be  negative!");
                else
                    this.price = value;
            }
        }

        public Common.GenderType Gender
        {
            get;
            protected set;
        }


        public virtual string Print()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("- {0} - {1}:", this.Brand, this.Name));
            result.Append("\n");
            result.Append(String.Format("  * Price: ${0}", this.Price));
            result.Append("\n");
            result.Append(String.Format("  * For gender: {0}", this.Gender.ToString()));
            return result.ToString();
        }
    }
}
