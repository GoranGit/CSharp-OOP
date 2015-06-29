
namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using ArmyOfCreatures.Logic.Specialties;
    using System.Globalization;

    public class DoubleAttackWhenAttacking:Specialty
    {
        private int rounds;
        public DoubleAttackWhenAttacking(int rounds):base()
        {
            if (rounds < 0)
                throw new ArgumentOutOfRangeException();
            else
                this.rounds = rounds;
        }

        public override void ApplyWhenAttacking(Logic.Battles.ICreaturesInBattle attackerWithSpecialty, Logic.Battles.ICreaturesInBattle defender)
        {
            if (attackerWithSpecialty == null)
                throw new ArgumentNullException();

            if (defender == null)
                throw new ArgumentNullException();
            else
            if (this.rounds > 0)
            {
                this.rounds--;
                attackerWithSpecialty.CurrentAttack = attackerWithSpecialty.CurrentAttack*2;
            }
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
