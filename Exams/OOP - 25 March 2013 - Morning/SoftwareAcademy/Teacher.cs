using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name  can't be null or empty!");
                else
                    this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            if (course == null)
                throw new ArgumentNullException("Course argument can't be null!");
            else
                this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder courses = new StringBuilder();
            foreach (var k in this.courses)
            {
                courses.Append(k.Name);
                courses.Append(", ");
            }

            string result = courses.ToString().TrimEnd();
            result = result.TrimEnd(',');

            return string.Format("Teacher: Name={0}{1}{2}{3}", this.Name,
                this.courses.Count == 0 ? "" : "; Courses=[",
                courses.Length == 0 ? "" : result,
                this.courses.Count == 0 ? "" : "]");

        }
    }
}
