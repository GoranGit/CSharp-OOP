
namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Giant : Fighter, IFighter, IGatherer
    {
        private bool gatherStone = false;

        public Giant(string name,Point position):base(name,position)
        {
            this.AttackPoints = 150;
            this.DefensePoints = 80;
            this.HitPoints = 200;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!this.gatherStone)
                {
                    this.AttackPoints += 100;
                    this.gatherStone = true;             
                }
                    return true;
            }
            else
                return false;
        }

        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            foreach (var target in availableTargets)
            {
                if (target.Owner != 0)
                    return availableTargets.IndexOf(target);
            }
            return -1;
        }
    }
}
