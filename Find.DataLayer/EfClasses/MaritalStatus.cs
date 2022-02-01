using Find.DataLayer.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public class MaritalStatus : Entity
    {
      
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        public MaritalStatus() { }
    }
}
