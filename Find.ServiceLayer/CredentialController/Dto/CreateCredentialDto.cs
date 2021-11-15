using Find.DataLayer.EfClasses;
using GenericServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceLayer.CredentialController.Dto
{
    public class CreateCredentialDto : ILinkToEntity<Object>
    {
        public int Id { get; set; }

        [HiddenInput(DisplayValue = false)]        
        public Guid UserId { get; set; }
        public int CredentialTypeId { get; set; }
        public string Identifier { get; set; }
        public string Secret { get; set; }
        public string Extra { get; set; } = "extra";

        public CreateCredentialDto()
        {

        }

        public struct PosibleCredential
        {
            public PosibleCredential(string identifer)
            {
                Email = identifer;
            }

            public string Email { get; set; }

        }

        public struct CredentialCreated
        {
            public CredentialCreated(int id, Guid UserId)
            {
                userId = UserId;
                Id = id;
                 
            }

            public Guid userId { get; set; }
            public int Id { get; set; }

        }

        public List<PosibleCredential> AllPossibeCredential { get; set; }

        public CredentialCreated CredentialCredential_User { get; set; }


        public void BeforeProceed(DbContext context)
        {
            AllPossibeCredential = context.Set<object>().Select(x => new PosibleCredential()).ToList(); 
        }

        //public void UserCredentialCreated(DbContext context, Guid UserId)
        //{
        //    //CredentialCredential_User = context.Set<object>().Where(y => y.UserId == UserId).Select(x => new CredentialCreated(x.Id, x.UserId)).FirstOrDefault();
        //}
    }
}
