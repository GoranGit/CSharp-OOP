﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse,ICourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }
        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if(value==null)
                    throw new ArgumentNullException("Lab can't be  null!");
                else
                    this.lab = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("; Lab={0}", this.Lab);
        }
    }
}
