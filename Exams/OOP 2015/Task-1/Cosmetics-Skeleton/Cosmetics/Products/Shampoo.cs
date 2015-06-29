
namespace Cosmetics.Products
{
    using System;
    using System.Text;
    using Common;
    using Contracts;

    public class Shampoo : Product, IProduct, IShampoo
    {
        private uint milliLiters;

        public Shampoo(string name, string brand, decimal price, GenderType genderType, uint milliLiters, UsageType usageType)
            : base(name, brand, genderType, price)
        {
            this.Milliliters = milliLiters;
            this.Usage = usageType;
        }

        public uint Milliliters
        {
            get
            {
                return this.milliLiters;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Milliliters can't be negative!");
                }
                else
                {
                    this.milliLiters = value;
                }
            }
        }

        public Common.UsageType Usage
        {
            get;
            private set;
        }

        public override decimal Price
        {
            get
            {
                return base.Price * this.Milliliters;
            }
            protected set
            {
                base.Price = value;
            }
        }

        public override string Print()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.Print());
            result.Append("\n");
            result.Append(String.Format("  * Quantity: {0} ml", this.Milliliters));
            result.Append("\n");
            result.Append(String.Format("  * Usage: {0}", this.Usage));
            return result.ToString();
        }
    }
}
