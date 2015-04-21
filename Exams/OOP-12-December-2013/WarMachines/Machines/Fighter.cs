namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IMachine, IFighter
    {
        private bool stealthMode;
        
           public Fighter(string name, double attackPoints, double defencePoints, bool stealthMode):this(name,null,attackPoints,defencePoints,stealthMode)
        {        
        }
        public Fighter(string name, IPilot pilot, double attackPoints, double defencePoints, bool stealthMode)
            : base(name, pilot, attackPoints, defencePoints)
        {
            this.HealthPoints = 200;
            this.StealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get 
            {
                return this.stealthMode;
            }
            protected set 
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(String.Format("\n *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));
            return result.ToString();
        }
    }
}
