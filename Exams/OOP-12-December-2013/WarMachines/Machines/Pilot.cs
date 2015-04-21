namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using System.Linq;
    using System.Text;
    public class Pilot : IPilot
    {
        private string name;
        private List<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }
                else
                    this.name = value;
            }
        }

        public List<IMachine> Machines
        {
            get
            {
                return new List<IMachine>(this.machines);
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
            this.machines = this.machines.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name).ToList();
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.Append(this.Name);
            report.Append(" - ");
            if (this.Machines.Count == 0)
            {
                report.Append("no machines");
            }
            else
            {
                if (this.Machines.Count == 1)
                {
                    report.Append("1 machine");
                }
                else
                {
                    report.Append(this.Machines.Count.ToString() + " machines");
                }
               
                foreach (var k in this.Machines)
                {
                    report.Append(k.ToString());
                }
               
            }
            return report.ToString();
        }
    }
}
