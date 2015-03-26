using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Animals
{
    public class TomCat : Cat, ISound
    {
         public TomCat(string name, string sex, int age)
            : base(name, sex, age)
        { }
         public override string Sex
         {
             get
             {
                 return base.Sex;
             }
             protected set
             {
                 if (value.Equals("Male"))
                     base.Sex = value;
                 else
                     throw new ArgumentException("TomCat must be Male!");
             }
         }
         public override string Sound()
         {
             return String.Format("I am TomCat mrauumrauuu!");
         }
    }
}
