using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    

    public class Knight : Fighter,IControllable,IFighter
    {
        private const int InitialPoints = 100;

        public Knight(string name,Point position,int owner):base(name,position,owner)
        {
            this.AttackPoints = InitialPoints;
            this.DefensePoints = InitialPoints;
            this.HitPoints = InitialPoints;
        }
    }
}
