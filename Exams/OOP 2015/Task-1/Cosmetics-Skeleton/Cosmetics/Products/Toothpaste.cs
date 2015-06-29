
namespace Cosmetics.Products
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Common;
    using Contracts;
    using Cosmetics;
    

    public class Toothpaste:Product,IProduct,IToothpaste
    {
        private ICollection<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType genderType, IList<string> ingredients)
            : base(name, brand, genderType, price)
        {
            this.ingredients = new List<string>();
            AddIngredient(ingredients);
        }
        public string Ingredients
        {
            get
            {
                return String.Join(", ", ingredients);
            }

        }

        public void AddIngredient(IList<string> ingredients)
        {
            foreach (var item in ingredients)
            {
                Validator.CheckIfStringIsNullOrEmpty(item, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Ingredient"));
                Validator.CheckIfStringLengthIsValid(item, 12, 4, String.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", 4, 12));
                this.ingredients.Add(item);
            }
           
        }
     
        public override string Print()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.Print());
            result.Append("\n");
            result.Append(String.Format("  * Ingredients: {0}", this.Ingredients));
            return result.ToString();
        }
    }
}
