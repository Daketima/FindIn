using Find.DataLayer.EfClasses;
using GenericServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.AccountController.Dto
{
    public class CreateUserDto : ILinkToEntity<User>
    {
        public Guid UserId { get; set; }
        public string FirstName { get;  set; }        
        public string LastName { get;  set; }
        public string MiddleName { get;  set; }
        public string PhoneNumber { get; set; }
        public string BVN { get;  set; }       
        public DateTime DateOfBirth { get; set; }
        public DateTime DateAdded { get;  set; }
       // public ICollection<UserRole> UserRole { get; set; }
        //public Credential Credential { get; set; }


        public CreateUserDto()
        {
            DateAdded = DateTime.Today;
        }

        public struct KeyName
        {
            public Guid UserId { get; set; }
           
            public KeyName(Guid id, string firstname, string lastname, string bvn)
            {
                UserId = id;
                FirstName = firstname;
                LastName = lastname;
                BVN = bvn;
            }

            public KeyName(string firstname, string lastname, string bvn)
            {
                UserId = new Guid();
                this.FirstName = firstname;
                this.LastName = lastname;
                this.BVN = bvn;
            }
            

            public string FirstName { get; }

            public string LastName { get; }

            public string BVN { get; set; }
        }

        public List<KeyName> AllPossibleUsers { get; private set; }

        public KeyName JustCreatedUser { get; set; }

        public List<KeyName> UserPossiblyExist { get; private set; }
      
        //public void BeforeDisplay (DbContext context)
        //{
        //    AllPossibleUsers = (List<KeyName>)context.Set<User>().Select(x => new KeyName(x.UserId, x.FirstName, x.LastName, x.BVN)).OrderBy(x => x.FirstName);
        //}

        //public void BeforeCreatingCredential(DbContext context)
        //{
        //    var JustCreatedUser = (KeyName)context.Set<User>().Select(x => new KeyName(x.FirstName, x.LastName, x.BVN)).FirstOrDefault();
          
        //}

        //public void CheckUserDuplicateBVN(DbContext context)
        //{
        //    UserPossiblyExist = (List<KeyName>)context.Set<User>().Select(x => new KeyName(x.UserId, x.FirstName, x.LastName, x.BVN)).OrderBy(x => x.FirstName);           
        //}

        //public void BeforeSaveSetDefaultRole(DbContext context)
        //{
        //    UserRole = 
        //}
    }
}
