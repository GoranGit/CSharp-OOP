namespace WarMachines.Engine
{
    using System;
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using WarMachines.Machines;
    using System.Linq;
    public class MachineFactory : IMachineFactory
    {
        private IList<IPilot> pilots;
        private IList<ITank> tanks;
        private IList<IFighter> fighters;
        public MachineFactory()
        {
            this.pilots = new List<IPilot>();
            this.tanks = new List<ITank>();
            this.fighters = new List<IFighter>();
        }


        public IPilot HirePilot(string name)
        {
            IPilot pilot = new Pilot(name);
            var k = this.pilots.Any(x => x.Name.Equals(name));
            if(k)
            {
                throw new ArgumentException("Alredy has pilot with this name!");
            }
            else
            {
                this.pilots.Add(pilot);
            }
            return pilot;
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            ITank tank = new Tank(name, attackPoints, defensePoints);
            var k = this.tanks.Any(x => x.Name.Equals(name));
            if(k)
            {
                throw new ArgumentException("Alredy has tank with this name!");
            }
            else
            {
                this.tanks.Add(tank);
            }
            return tank;
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            IFighter fighter = new Fighter(name, attackPoints, defensePoints,stealthMode);
            var k = this.fighters.Any(x =>  Object.Equals(x.Name,name));
            if (k)
            {
                throw new ArgumentException("Alredy has fighter with this name!");
            }
            else
            {
                this.fighters.Add(fighter);
            }
            return fighter;
        }
    }
}
