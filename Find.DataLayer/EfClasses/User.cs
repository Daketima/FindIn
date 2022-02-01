using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Find.DataLayer.EfClasses
{
   public class User
    {
        public Guid UserId { get; set; }
        
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

    
        public HashSet<EducationBackground> _EeducationBackGround;
        public HashSet<Address> _userAddress;
        public HashSet<Idea> _idea;
        public HashSet<UserRole> _UserRole;
        public HashSet<LoginCredential> _loginCredential;

        //-------------------------------------------------------------------
        // Other tables reletionship

        public Address Address { get; set; }
        public LoginCredential LoginCredentil { get; set; }
        public IList<UserRole> UserRole { get; set; }
        public IList<Idea> Idea { get; set; }
        public IList<Company> Company { get; set; }


        public User()
        {

        }

        public User (string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public void SignUp(string Username,  string Password)
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
