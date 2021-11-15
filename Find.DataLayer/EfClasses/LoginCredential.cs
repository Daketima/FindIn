using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
   public class LoginCredential
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Secret { get; set; }
        public int CredentialType  { get; set; }
    }
}
