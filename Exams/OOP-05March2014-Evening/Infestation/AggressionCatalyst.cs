namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AggressionCatalyst : Supplement, ISupplement
    {
        protected const int InitialAggression = 3;

        public AggressionCatalyst(int power = 0, int health = 0)
            : base(power, health, InitialAggression)
        {
        }
    }
}
