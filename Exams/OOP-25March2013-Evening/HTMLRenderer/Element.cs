using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class Element : IElement
    {
        private string name;
        private string textContent;
        private ICollection<IElement> childElements;

        public Element(string name=null,string textContent=null)
        {
            this.Name = name;
            this.TextContent = textContent;
            this.childElements = new List<IElement>();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            protected set
            {
                    this.name = value;
            }
        }

        public string TextContent
        {
            get
            {
                return ReplaceSpecSimols();
            }
            set
            {
                this.textContent = value;
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get 
            {
                return new List<IElement>(this.childElements);
            }
        }

        public void AddElement(IElement element)
        {
            if (element == null)
                throw new ArgumentNullException("Can not add null element!");
            else
                this.childElements.Add(element);
              
        }

        public void Render(StringBuilder output)
        {
            output.Append(String.Format("<{0}>", this.Name));
            if(this.textContent!=null)
            {
                output.Append(this.TextContent);
            }
            if(this.ChildElements!=null)
            foreach (var child in this.ChildElements)
            {
                if (child.TextContent != null)
                    child.Render(output);
            }
            output.Append(String.Format("</{0}>", this.Name));
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            this.Render(output);
            return output.ToString();
        }

        private string ReplaceSpecSimols()
        {
            StringBuilder result = new StringBuilder();
            if(this.textContent!=null)
            foreach (var item in this.textContent)
            {
                if (SpecialSimbols.SpecialSimbolsDic.ContainsKey(item))
                    result.Append(SpecialSimbols.SpecialSimbolsDic[item]);
                else
                    result.Append(item);
            }
            return result.ToString();
        }

    }
}
