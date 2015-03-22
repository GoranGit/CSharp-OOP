namespace Structure
{
    using System;
    [Serializable]
    public struct Point3D
    {
        private static readonly Point3D start = new Point3D(0, 0, 0);

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static Point3D Start
        {
            get
            {
                return start;
            }

        }


        public Point3D(int X,int Y,int Z):this()
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        
        public override string ToString()
        {
            return String.Format("X={0}, Y={1}, Z={2}",this.X,this.Y,this.Z);
        }
    }
}
