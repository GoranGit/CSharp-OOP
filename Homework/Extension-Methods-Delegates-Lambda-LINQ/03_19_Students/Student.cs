namespace _03_19_Students
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Student(string fName,string lName,int age)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("First Name: {0}  Last Name:{1}  Age:{2}", this.FirstName, this.LastName,this.Age);
        }
        

    }
}
