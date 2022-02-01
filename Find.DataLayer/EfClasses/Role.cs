using Find.DataLayer.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public class Role : Entity
    {           
        public string Name { get; set; }

        public Role () {  }
    }
}
