using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
     public class UserRole
    {
        public Guid RoleId { get; set; }
        public Guid UserId { get; set; }
    }
}
