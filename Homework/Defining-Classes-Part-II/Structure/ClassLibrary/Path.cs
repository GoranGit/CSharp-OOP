
namespace Structure
{
    using System;
        [Serializable]
    public class Path
    {
        public Point3D[] Points { get; set; }

            public Path()
        {
                this.Points = new Point3D[100];
        }

            
    }
}
