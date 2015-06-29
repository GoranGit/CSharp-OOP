
namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Common;
    using Cosmetics;

    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(Contracts.IProduct product)
        {
            Validator.CheckIfNull(products);
            this.products.Add(product);
        }

        public void RemoveProduct(Contracts.IProduct product)
        {
            Validator.CheckIfNull(products);
            this.products.Remove(product);
        }

        public bool ContainsProduct(Contracts.IProduct product)
        {
            Validator.CheckIfNull(products);
            return this.products.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal price = 0;

            foreach(var product in this.products)
            {
                price += product.Price;
            }
            return price;
        }
    }
}
