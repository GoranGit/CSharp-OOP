using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class Binary:Document,IDocument
    {
        public Binary(string name,long size = 0,string content= null):base(name,content)
        {
            this.Size = size;
        }

        public long Size { get; protected set; }
    }
}
