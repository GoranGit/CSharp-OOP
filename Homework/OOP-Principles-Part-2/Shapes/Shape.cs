namespace Shapes
{
    using System;
    public abstract class Shape
    {
        public double width;
        public double height;
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }      
        public abstract double CalculateSurface();
        public double Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Width can't be  negative!");
                else
                    this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Width can't be  negative!");
                else
                    this.height = value;
            }
        }
    }
}
