using Find.DataLayer.EfClasses;
using GenericServices;
using System;

namespace ServiceLayer.AccountController.Dto
{
    public class AddCredentialDto : ILinkToEntity<LoginCredential>
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int CredentialTypeId { get; set; }
        public string Identifier { get; set; }
        public string Secret { get; set; }
        public string Extra { get; set; }
    }
}
