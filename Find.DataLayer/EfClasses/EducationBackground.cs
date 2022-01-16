using Find.DataLayer.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public class EducationBackground : Entity
    {       
        public string Name { get; set; }

        public int Level { get; set; }

        public EducationBackground() { }
    }
}
