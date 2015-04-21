namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Marine : Human
    {
        public Marine(string id):base(id)
        {
            base.AddSupplement(new WeaponrySkill());
        }
       
        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (unit.Power <= this.Aggression)
                return true;
            else
                return false;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MinValue, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Health > optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }
            return optimalAttackableUnit;
        }
    }
}
