
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;
    public class Machine : WarMachines.Interfaces.IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;
        

        public Machine(string name,IPilot pilot,double attackPoints,double defencePoints)
        {
            this.Name = name;
           this.Pilot = pilot;
           this.targets = new List<string>();
           this.AttackPoints = attackPoints;
           this.DefensePoints = defencePoints;
        }
        public Machine(string name,double attackPoints,double defencePoints):this( name,null,attackPoints,defencePoints)
        {
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }
                else
                    this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                this.pilot = value;
                
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if(value<=0)
                {
                    this.healthPoints = 0;
                }else
                {
                    this.healthPoints = value;
                }
            }
        }

        public double AttackPoints
        {
            get 
            {
                return this.attackPoints;
            }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("attack points can't be  negative  or 0!");
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get 
            {
                return this.defensePoints;
            }
           protected set
            {
                if (value <= 0)
                    throw new IndexOutOfRangeException("Defense points can't be negatine!");
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get 
            {
                return this.targets;    
            }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("\n- {0}", this.Name));
            result.Append(String.Format("\n *Type: {0}", this.GetType().Name));
            result.Append(String.Format("\n *Health: {0}", this.HealthPoints));
            result.Append(String.Format("\n *Attack: {0}", this.AttackPoints));
            result.Append(String.Format("\n *Defense: {0}", this.DefensePoints));
            result.Append(String.Format("\n *Targets: {0}", this.Targets.Count==0?"None": String.Join(", ", this.Targets)));
            return result.ToString();
        }
    }
}
