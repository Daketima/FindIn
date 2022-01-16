using Find.DataLayer.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
   public class LoginCredential : Entity
    {        
        private long UserId { get; set; }
        private string Email { get; set; }
        private string Secret { get; set; }          

        public User User { get; set;}

        public LoginCredential() { }

        public LoginCredential ( string email, string secret ) 
        {
            //UserId = userId;
            Email = email;
            Secret = secret;
        }
    }
}
