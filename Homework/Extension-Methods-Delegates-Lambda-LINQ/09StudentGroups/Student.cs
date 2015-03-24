namespace _09StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Student
    {
        private List<int> marks;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }
            set
            {
                this.marks = new List<int>(value);
            }
        }
        public int GroupNumber { get; set; }

        public Student(string fName, string lName, string fn, string tel, string email, List<int> marks, int gNumber)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.marks = new List<int>(marks); // becouse it should be  not refered from outsitde
            this.GroupNumber = gNumber;
        }
        public override string ToString()
        {
            StringBuilder k = new StringBuilder();
            foreach (var item in this.marks)
            {
                k.Append(item);
                k.Append(" ");
            }

            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", this.FirstName, this.LastName, this.FN, this.Tel, this.Tel, this.Email, k, this.GroupNumber);
        }
    }
}
