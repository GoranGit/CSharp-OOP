namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Supplement : ISupplement
    {
        private int powerEffect;
        private int health;
        private int aggressionEffect;

        public Supplement(int powerEffect,int healthEffect,int aggressionEffect)
        {
            this.HealthEffect = healthEffect;
            this.AggressionEffect = aggressionEffect;
            this.PowerEffect = powerEffect;
        }

        public int PowerEffect
        {
            get
            {
                return this.powerEffect;
            }
            protected set
            {
                //if (value < 0)
                //    throw new ArgumentException("Power effect value can't be  negative!");
                //else
                    this.powerEffect = value;
            }
        }

        public int HealthEffect
        {
            get
            {
                return this.health;
            }
            protected set
            {
            //    if (value < 0)
            //        throw new ArgumentException("Health effect can't be  negative!");
            //    else
                    this.health = value;
            }
        }

        public int AggressionEffect
        {
            get
            {
                return this.aggressionEffect;
            }
            protected set
            {
                //if (value < 0)
                //    throw new ArgumentException("Aggression effect can't be  negative!");
                //else
                    this.aggressionEffect = value;
            }
        }


        public virtual void ReactTo(ISupplement otherSupplement)
        {
            
        }
    }
}
