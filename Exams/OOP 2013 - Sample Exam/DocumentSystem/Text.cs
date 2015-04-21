using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class Text:Document,IDocument,IEditable,IDocument
    {
        public Text(string name,string charset=null,string content=null):base(name,content)
        {
            this.Charset = charset;  
        }

        public string Charset { get; private set; }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
