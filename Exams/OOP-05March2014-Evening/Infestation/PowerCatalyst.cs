
namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PowerCatalyst : Supplement, ISupplement
    {
        protected const int InitialPower = 3;

        public PowerCatalyst(int health =0, int aggression =0)
            : base(InitialPower, health, aggression)
        {
        }
    }
}
