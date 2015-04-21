using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public abstract class Fighter:Character,IFighter
    {

        public Fighter(string name,Point position,int owner = 0):base(name,position,owner)
        {
        }


        public int AttackPoints
        {
            get;
            protected set;
        }

        public int DefensePoints
        {
            get;
            protected set;
        }

        public virtual int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if ((availableTargets[i].Owner != this.Owner) && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
