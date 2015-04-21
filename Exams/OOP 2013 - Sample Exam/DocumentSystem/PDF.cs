
namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PDF:Binary,IEncryptable
    {
        private int numberOfPages;

        public PDF(string name,bool isEncripted = false,int numberOfPages=0,long size=0,string content=null):base(name,size,content)
        {
            this.NumberOfPages = numberOfPages;
            this.IsEncrypted = isEncripted;
        }

        public int NumberOfPages
        {
            get
            {
                return this.numberOfPages;
            }
            private set
            {
                ValidationData.LessThanZero(value, "Number of pages");
                this.numberOfPages = value;
            }
        }

        public bool IsEncrypted
        {
            get;
            private set;
        }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }
    }
}
