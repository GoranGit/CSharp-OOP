namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class InfestationSpores : Supplement, ISupplement
    {
        public const int BaseAggressionEffect = 20;
        public const int BasePowerEffect = -1;
        public const int BaseHealthEffect = 0;
        public InfestationSpores():base(BasePowerEffect,BaseHealthEffect,BasePowerEffect)
        {
                
        }
        public override void ReactTo(ISupplement otherSupplement)
        {
            base.ReactTo(otherSupplement);
        }
    }
}
