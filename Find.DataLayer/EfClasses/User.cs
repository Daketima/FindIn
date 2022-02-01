using Find.DataLayer.Abstractions;
using StatusGeneric;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public  class User : Entity
    {
        public LoginCredential UserLoginDetail { get; private set;}      
        
        public HashSet<Idea> _idea;
        
        public HashSet<UserRole> _userRole;
        
        public LoginCredential _loginCredential;
        
        public HashSet<Company> _company;


        //-------------------------------------------------------------------
        // Other tables reletionship

       // public Address Address => _userAddress;
        
        public LoginCredential LoginCredential => _loginCredential;
        
        public ICollection<UserRole> UserRole => _userRole?.ToList();
        
        public ICollection<Idea> Idea => _idea?.ToList();
       
        //public ICollection<Company> Company => _company?.ToList();


        public User()
        {

        }

        




        public User(string firstName, string middleName, string lastName, int genderId, string bvn, DateTime dateOfBirth, int maritalStatusId)
        {
           // if (string.IsNullOrEmpty(firstName))
             //   throw new ArgumentNullException(nameof(firstName));

            //FirstName = firstName;
            //MiddleName = middleName;
            //LastName = lastName;
            //GenderId = genderId;
            //DateOfBirth = dateOfBirth;
        }

        public User(string firstName, string middleName, string lastName, int genderId, string bvn, DateTime dateOfBirth, int maritalStatusId, string email, string secret)
        {
        //    FirstName = firstName;
        //    MiddleName = middleName;
        //    LastName = lastName;
        //    GenderId = genderId;
        //    DateOfBirth = dateOfBirth;
            _loginCredential = new LoginCredential(email: email, secret: secret);
        }

        public static IStatusGeneric<User> CreateUser(string firstName, string middleName, string lastName, int genderId, string bvn, DateTime dateOfBirth, int maritalStatusId, string email, string secret)
        {
            StatusGenericHandler<User> status = new StatusGenericHandler<User>();

            User user = new User
            {
                //FirstName = firstName,
                //MiddleName = middleName,
                //LastName = lastName,
                //GenderId = genderId,
                //DateOfBirth = dateOfBirth,
                //MaritalStatusId = maritalStatusId,
                //_loginCredential = new LoginCredential(email, secret)
            };

            return status.SetResult(user);
        }

        public void SetuserCredential(string email, string secret) { }

        public void LoginUser()
        {

        }


    }
}
