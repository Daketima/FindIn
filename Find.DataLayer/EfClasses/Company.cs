using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
   public class Company
    {
        public int CompanyId { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string RegistrationDate { get; set; }
        public string RgistrationNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPerson { get; set; }
    }
}
