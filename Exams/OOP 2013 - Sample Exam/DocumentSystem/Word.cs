
namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Word:Office,IEncryptable,IEditable,IDocument
    {
        private int numberOfCharacters;

        public Word(string name,int numberOfCharacters,bool isEncripted =false, string version=null,long size=0,string content=null):base(name,version,size,content)
        {
            this.NumberOfCharacters = numberOfCharacters;   
        }
        public int NumberOfCharacters { 
            get
            {
                return this.numberOfCharacters;
            }
            private set 
            {
                ValidationData.LessThanZero(value, "Characters");
                this.numberOfCharacters = value;
            }
        }

       
    }
}
