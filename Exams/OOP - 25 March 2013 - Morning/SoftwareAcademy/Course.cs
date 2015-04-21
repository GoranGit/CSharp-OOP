using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public abstract class Course : ICourse
    {
        private string name;
        private List<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                    throw new ArgumentException("Name  parameter can't be  null or empty!");
            }
        }

        public ITeacher Teacher
        {
            get;
            set;
        }

        public void AddTopic(string topic)
        {
            if (string.IsNullOrEmpty(topic))
            {
                throw new ArgumentException("Topic  parameter can't be  null or empty!");
            }
            else
                this.topics.Add(topic);

        }

        public override string ToString()
        {

            StringBuilder topicss = new StringBuilder();
            foreach (var item in this.topics)
            {
                topicss.Append(item);
                topicss.Append(", ");
            }
            string result = topicss.ToString().TrimEnd();
            result = result.TrimEnd(',');
            return string.Format("{0}: Name={1}{2}{3}", this.GetType().Name, this.Name, this.Teacher != null ? "; Teacher="+this.Teacher.Name : "", this.topics.Count > 0 ? "; Topics=[" + result + "]" : "");
        }
    }
}
