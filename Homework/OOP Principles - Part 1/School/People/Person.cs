using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.People
{
    public class Person : IPerson, School.IComents
    {
        private string name;
        private string comment;
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, string comment):this(name)
        {
            this.CommentText=comment;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    this.name = value;
                else
                    throw new ArgumentNullException("Name can't be null or empty string!");
            }
        }
        public string CommentText
        {
            get
            {
                if (String.IsNullOrEmpty(this.comment))
                    return "No comment!";
                else
                    return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Name:{0} Comment: {1}",this.Name,this.CommentText);
        }
    }
   
}
