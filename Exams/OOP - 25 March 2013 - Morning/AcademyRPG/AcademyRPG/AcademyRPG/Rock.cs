
namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Rock:StaticObject,IResource
    {
        public Rock(int hitPoints,Point position):base(position)
        {
            this.HitPoints = hitPoints;
            this.Type = ResourceType.Stone;
            this.Quantity = hitPoints / 2;
        }


        public int Quantity
        {
            get;
            private set;
        }

        public ResourceType Type
        {
            get;
            private set;
        }
    }
}
