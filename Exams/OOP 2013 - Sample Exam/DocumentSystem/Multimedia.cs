namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Multimedia : Binary,IDocument
    {
        private int length;
        public Multimedia(string name, int length = 0, long size = 0, string content=null)
            : base(name, size, content)
        {
            this.Length = length;
        }
        public int Length
        {
            get
            {
                return this.length;
            }
            protected set
            {
                ValidationData.LessThanZero(value, "Lenght");
                this.length = value;
            }
        }
    }
}
