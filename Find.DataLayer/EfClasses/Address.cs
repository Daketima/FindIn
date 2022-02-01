using Find.DataLayer.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public class Address : Entity
    { 
       
        public string UserAddress { get; set; }
        public string Country { get; set; }

        public Address () { }
    }
}
