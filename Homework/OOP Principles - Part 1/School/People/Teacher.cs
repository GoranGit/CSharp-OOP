using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.People
{
    public class Teacher : Person, IPerson, School.IComents
    {
        private List<Discipline> disciplines;
        public Teacher(string name):base(name)
        {
            this.disciplines = new List<Discipline>();
        }
        public List<Discipline> Disciplines
        {
            get
            {
                if (this.disciplines == null)
                    throw new ArgumentNullException("No disciplines in the  list!");
                else
                    return new List<Discipline>(this.disciplines);
            }
        }
        public void AddDiscipline(Discipline discipline)
        {
            if (discipline != null)
                this.disciplines.Add(discipline);
            else
                throw new ArgumentNullException("Parameter discipline  can't be  null!");
        }
        public override string ToString()
        {
            return String.Format("Teacher: {0} {1}", base.ToString(),String.Join("\n",this.disciplines));
        }
    }
}
