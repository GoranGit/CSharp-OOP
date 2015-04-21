namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Excel : Office,IEncryptable,IDocument
    {
        private int numberOfRows;
        private int numberOfColums;

        public Excel(string name,bool isEncripted = false,string version=null, int numberOfRows=0,int numberOfColums=0,long size = 0, string content = null)
            : base(name, version,size, content)
        {
            this.NumberOfColums = numberOfColums;
            this.NumberOfRows = numberOfRows;
          
        }
        public int NumberOfRows 
        {
            get
            {
                return this.numberOfRows;
            }
            private set
            {
                ValidationData.LessThanZero(value,"Number of rows");
                this.numberOfRows = value;
            }
        }
        public int NumberOfColums 
        {
            get
            {
                return this.numberOfColums;
            }
            private set
            {
                ValidationData.LessThanZero(value, "Number of colums");
                this.numberOfColums = value;
            }
        }
    }
}
