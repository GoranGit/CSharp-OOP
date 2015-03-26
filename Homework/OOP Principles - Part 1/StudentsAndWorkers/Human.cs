namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;
        public Human(string fName,string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public override string ToString()
        {
            return String.Format("{0} {1}",this.FirstName,this.LastName);
        }     
    }
}
