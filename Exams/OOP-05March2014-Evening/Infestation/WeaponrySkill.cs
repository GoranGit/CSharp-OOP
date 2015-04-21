using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class WeaponrySkill : Supplement, ISupplement
    {
        private const int BaseInfluence = 0;
        public WeaponrySkill():base(BaseInfluence,BaseInfluence,BaseInfluence)
        {
        }
    }
}
