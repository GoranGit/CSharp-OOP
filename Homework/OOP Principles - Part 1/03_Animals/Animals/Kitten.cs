using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Animals
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, string sex, int age):base(name, sex, age)
        {         
        }
        public override string Sound()
        {
            return String.Format("I am  Kitten KALALAKAAL!");
        }
        public override string Sex
        {
            get
            {
                return base.Sex;
            }
            protected set
            {
                if (value.Equals("Female"))
                    base.Sex = value;
                else
                    throw new ArgumentException("Kitten must bew female!");
            }
        }
    }
}
