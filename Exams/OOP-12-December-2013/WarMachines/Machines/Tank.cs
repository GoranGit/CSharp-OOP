using System;
using System.Collections.Generic;
using System.Linq;

namespace WarMachines.Machines
{
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Tank : Machine, IMachine, ITank
    {
        private bool defenseMode;

        #region constructors
        public Tank(string name, double attackPoints, double defencePoints):this(name,null,attackPoints,defencePoints)
        {        
        }
        public Tank(string name, IPilot pilot, double attackPoints, double defencePoints)
            : base(name, pilot, attackPoints, defencePoints)
        {
           
            this.AttackPoints -= 40;
            this.DefensePoints += 30;
            this.DefenseMode = true;
            this.HealthPoints = 100;
        }
        #endregion

        public bool DefenseMode
        {
            get 
            {
                return this.defenseMode;
            }
            private set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if(this.DefenseMode == true)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
 	             result.Append(base.ToString());
                 result.Append(String.Format("\n *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));
                 return result.ToString();
        }
    }
}
