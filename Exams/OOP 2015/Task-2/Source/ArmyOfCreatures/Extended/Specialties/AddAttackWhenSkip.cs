
namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Battles;
    using System;
    using ArmyOfCreatures.Logic.Specialties;

    public class AddAttackWhenSkip:Specialty
    {
        private int valueToAdd;

        public AddAttackWhenSkip(int valueToAdd)
        {
            if (valueToAdd < 1 || valueToAdd > 10)
                throw new ArgumentOutOfRangeException();
            else
                this.valueToAdd = valueToAdd;
        }
        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.valueToAdd;
            skipCreature.CurrentAttack = skipCreature.PermanentAttack;
        }

        public override string ToString()
        {
            return String.Format("{0}({1})", base.ToString(), this.valueToAdd);
        }
    }
}
