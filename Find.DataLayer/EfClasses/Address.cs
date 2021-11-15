using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public class Address
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string UserAddress { get; set; }
        public string Country { get; set; }
    }
}
