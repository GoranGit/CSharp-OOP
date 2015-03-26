namespace School
{
    using System;
    using System.Collections.Generic;
    using School.People;
    public class SchoolClass
    {
        private static List<int> identifiers = new List<int>();
        private List<Teacher> teachers;
        private string name;
        private int classIdentifier;
        public SchoolClass(string name,int classIdentifier)
        {
            this.name = name;
            this.teachers = new List<Teacher>();
            this.ClassIdentifier = classIdentifier;
         
        }
        public string Name
        {
            get
            {
                if (this.name == null)
                    throw new ArgumentNullException("The  name  is null");
                else
                    return this.name;
            }
            set
            {
                if (this.name == null)
                    throw new ArgumentNullException("Name  can't be  null");
                else
                    this.name = value;
            }
        }
        public int ClassIdentifier 
        {
            get
            {
                return this.classIdentifier;
            }
            private set
            {
                if (identifiers.Contains(value))
                    throw new ArgumentException("This class identifier is alredy assigned!");
                else
                {
                    this.classIdentifier = value;
                    identifiers.Add(value);
                }
            }
        }
        public List<Teacher> Teachers 
        {
            get
            {
                if (this.teachers.Count != 0)
                    return new List<Teacher>(this.teachers);
                else
                    throw new ArgumentNullException("No teachers in the list!");
            }
           
        }
        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }   
    }
}
