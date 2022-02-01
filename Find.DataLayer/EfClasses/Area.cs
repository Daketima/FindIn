using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public class Area : Entity
    {        
        public string Name { get; set; }
        public string Description { get; set; }
        public string DateCreated { get; set; }
        public bool IsActive { get; set; }

        public Area () { }
    }
}
