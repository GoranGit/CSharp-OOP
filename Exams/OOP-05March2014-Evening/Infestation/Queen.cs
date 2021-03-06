﻿namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Queen : Unit
    {
        private const int BaseHealth = 30;
        private const int BasePower = 1;
        private const int BaseAggression = 1;

        public Queen(string id):base(id,UnitClassification.Psionic,BaseHealth,BasePower,BaseAggression)
        {

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

    }
}
