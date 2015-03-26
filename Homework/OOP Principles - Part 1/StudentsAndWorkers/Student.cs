namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    public class Student : Human
    {
        private double grade;
        public Student(string firstName,string lastName,double grade):base(firstName,lastName)
        {
            this.Grade = grade;
        }
        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("grade can't be negative!");
                else
                    this.grade = value;

            }
        }
        public override string ToString()
        {
            return base.ToString() + "Grade:"+this.Grade;
        }
    }
}
