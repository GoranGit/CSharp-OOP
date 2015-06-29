
namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;  

    public class DoubleDamage:Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            if(rounds<1 || rounds>10)
                throw new ArgumentOutOfRangeException("Double  damage   rounds must be  grather tahan 0 and less than 11!");
           else
                this.rounds = rounds;

        }

        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty,
            ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.rounds > 0)
            {
                this.rounds--;
                return currentDamage * 2;
                
            }
            else
                return currentDamage;
        }

        public override string ToString()
        {
            return String.Format("{0}({1})",base.ToString(), this.rounds);
        }  
    }
}
