namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Audio:Multimedia,IDocument
    {
        private int sampleRate;

        public int SampleRate 
        {
            get
            {
                return this.sampleRate;
            }
            private set
            {
                ValidationData.LessThanZero(value, "Sample rate in Hz");
                this.sampleRate = value;
            }

        }
    }
}
