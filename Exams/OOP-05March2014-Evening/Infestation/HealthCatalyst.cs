
namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HealthCatalyst : Supplement, ISupplement
    {
        protected const int InitialHealth = 3;

        public HealthCatalyst(int power = 0, int aggression = 0)
            : base(power, InitialHealth, aggression)
        {
        }
    }
}
