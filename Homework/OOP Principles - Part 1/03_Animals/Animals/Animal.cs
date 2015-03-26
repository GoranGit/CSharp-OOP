using System;
using System.Collections.Generic;

namespace _03_Animals
{
    using System;
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private string sex;
        public Animal(int age,string name,string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 50)
                    throw new ArgumentOutOfRangeException("Ages should be between 1 and 50!");
                else
                    this.age = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Name  can't be  null or empty string!");
                else
                    this.name = value;
            }
        }
        public virtual string Sex
        {
            get
            {
                return this.sex;
            }
            protected set
            {
                if (value.Equals("Male") || value.Equals("Female"))
                    this.sex = value;
                else
                    throw new ArgumentException("Sex must be Male  or Female!");
            }
        }
        public abstract string Sound();
    }
}
