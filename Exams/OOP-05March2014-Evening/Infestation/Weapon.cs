namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Weapon : Supplement, ISupplement
    {
        private const int BaseWeaponEffects = 0;

        public Weapon()
            : this(BaseWeaponEffects, BaseWeaponEffects, BaseWeaponEffects)
        {

        }

        public Weapon(int powerEffect, int healthEffect, int aggressionEffect)
            : base(powerEffect, healthEffect, aggressionEffect)
        { }

    }
}
