using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class Office : Binary,IDocument,IEncryptable
    {
        public Office(string name,string version=null, long size=0, string content=null)
            : base(name, size, content)
        {
            this.Version = version;
        }

        public string Version { get; protected set; }

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
