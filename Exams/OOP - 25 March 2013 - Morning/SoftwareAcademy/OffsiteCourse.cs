using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, IOffsiteCourse,ICourse
    {
        private string town;

        public OffsiteCourse(string name,ITeacher teacher,string town):base(name,teacher)
        {
            this.Town = town;
        }


        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Town cant be  null or empty!");
                else
                    this.town = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("; Town={0}", this.town);
        }
    }
}
