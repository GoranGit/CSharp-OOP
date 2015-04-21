using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Parasite : Unit
    {
        private const int BaseHealth = 1;
        private const int BasePower = 1;
        private const int BaseAggression = 1;

        public Parasite(string id):base(id,UnitClassification.Biological,BaseHealth,BasePower,BaseAggression)
        {

        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
           IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Health < optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }
            return optimalAttackableUnit;
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (this.Id == unit.Id)
                return false;
            else
                return true;
        }

        //public void Infest(Unit target)
        //{
        //  target.AddSupplement(new InfestationSpores());
        //}

    }
}
