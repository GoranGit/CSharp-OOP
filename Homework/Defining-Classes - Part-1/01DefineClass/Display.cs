namespace _01DefineClass
{
    using System;
    public class Display
    {
        private double size;
        private int numColors;

        public Display(double size, int numColors)
        {
            this.size = size;
            this.numColors = numColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public int NummColors
        {
            get
            {
                return this.numColors;
            }
            set
            {
                this.numColors = value;
            }
        }
        public override string ToString()
        {
            return String.Format(" Display Size{0}, Number of colors{1}", this.size, this.numColors);
        }



    }
}
