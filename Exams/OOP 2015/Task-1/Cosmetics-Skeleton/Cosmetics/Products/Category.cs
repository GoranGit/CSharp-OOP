
namespace Cosmetics.Products
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;
    using Cosmetics.Products;
    using Cosmetics.Common;
    using Cosmetics.Contracts;
     
    public class Category : Cosmetics.Contracts.ICategory
    {
        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(value, 15, 2, String.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2, 15));
                this.name = value;
            }
        }

        public void AddCosmetics(Contracts.IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics"));
            this.products.Add(cosmetics);
            this.products = this.products.OrderBy(x => x.Brand).ThenByDescending(y => y.Price).ToList<IProduct>();
        }

        // Check if this work properly
        public void RemoveCosmetics(Contracts.IProduct cosmetics)
        {
            if (!this.products.Remove(cosmetics))
                throw new ArgumentException(String.Format("Product {0} does not exist in category {0}!", cosmetics.Name, this.Name));
        }

        public string Print()
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, this.products.Count == 1 ? "product" : "products"));
            foreach (var product in this.products)
            {
                result.Append("\n");
                result.Append(product.Print());
            }
            return result.ToString();
        }
    }
}
