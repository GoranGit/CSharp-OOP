using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.People
{
    public class Student : Person, IPerson, School.IComents
    {
        private int classIdentifier;
        public Student(int classIdentifier,string name,string comment):base(name,comment)
        {
            this.ClasIdentifier = classIdentifier;
        }
        public Student(int classIdentifier,string name):base(name)
        {
            this.ClasIdentifier = classIdentifier;
        }
        public int ClasIdentifier 
        {
            get 
            {
                return this.classIdentifier;
            }
          private set
            {
                if (value <0)
                    throw new ArgumentOutOfRangeException("Class identifier can't be negative!");
                else
                    this.classIdentifier = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Student {0} ", base.ToString());
        }
    }
}
