
namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Document:IDocument
    {
        private string name;
        private ICollection<KeyValuePair<string,object>> properties;

        public Document(string name,string content=null)
        {
            this.Name = name;
            this.Content = content;
            this.properties = new List<KeyValuePair<string, object>>() ;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name  can't be  null or empty!");
                else
                    this.name = value;
            }
        }

        public string Content
        {
            get;
            protected set;
        }

        public void LoadProperty(string key, string value)
        {
            this.properties.Add(new KeyValuePair<string, object>(key, value));
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output = new List<KeyValuePair<string, object>>(this.properties);
        }
    }
}
