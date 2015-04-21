using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja:Fighter,IFighter,IControllable,IGatherer
    {
        private int hitPoints;

        public Ninja(string name,Point position,int owner):base(name,position,owner)
        {
            this.HitPoints = 1;
            this.AttackPoints = 0;

        }

        public new int HitPoints
        {
            get
            {
                return this.hitPoints;
            }
            set
            {
                this.hitPoints = 1;
            }
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }
            else
                if (resource.Type == ResourceType.Stone)
                {
                    this.AttackPoints += (resource.Quantity * 2);
                    return true;
                }
                else
                    return false;
        }

        public override int GetTargetIndex(List<WorldObject> availableTargets)
        { 
            var k = availableTargets.Where(x=>x.Owner!=this.Owner && x.Owner!=0).OrderByDescending(y=>y.HitPoints).FirstOrDefault();
            if (k != null)
                return availableTargets.IndexOf(k);
            else
                return -1;
        }
    }
}
