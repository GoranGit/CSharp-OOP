using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;
        public Worker(string firstName,string lastName,double weekSelary,int workHoursPerDay):base(firstName,lastName)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeakSalary = weekSelary;
        }
        public double WeakSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Selary can't be negative!");
                else
                    this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Selary can't be negative!");
                else
                    this.workHoursPerDay = value;
            }
        }
        public double MoneyPerHour()
        {
            return WeakSalary / (5 * workHoursPerDay);
        }
        public override string ToString()
        {
            return base.ToString()+ String.Format("Week salary:{0} Work hour per day:{1}  Money per hour:{2}",this.weekSalary,this.workHoursPerDay,this.MoneyPerHour());
        }
    }
}
