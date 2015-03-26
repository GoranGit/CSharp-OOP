using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, string sex, int age)
            : base(age, name, sex)
        { }
        public override string Sound()
        {
            return String.Format("I am Dog BAUUU!");
        }
    }
}
