using Find.DataLayer.EfCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Find.DataLayer.EfClasses
{
   public class User
    {
        public long UserId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        
        [Required]
        public int Gender { get; set; }        
     
        public string HomeAddress { get; set; }
       
        [Required]
        [MaxLength(11)]
        public string BVN { get; set; }               
        
        public bool IsActive { get; set; }
       
        public int MaritalStatusId { get; set; }
        
        public DateTime DateCreated { get; set; }      


        public User()
        {

        }

        public User (string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public void SignUp(string Username,  string Password, EfCoreContext context)
        {

        }

        public void Login(string username, string EncrptedPassword)
        {

        }

        public void AddToRole(string UserId, string RoleId)
        {
            RoleId = RoleId.ToLower();
        }



    }
}
