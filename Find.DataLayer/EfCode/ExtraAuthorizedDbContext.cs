using DataLayer.ExtraAuthClasses;
using Find.DataLayer.ExtraAuthClasses;
using Microsoft.EntityFrameworkCore;
using RefreshClaimsParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfCode
{
    public class ExtraAuthorizedDbContext : DbContext, ITimeStore
    {
        private readonly IAuthenticationChanges _authChange;

        public DbSet<UserToRole> UserToRole { get; internal set; }

        public void AddUpdateValue(string key, long ticks)
        {
            throw new NotImplementedException();
        }

        public long? GetValueFromStore(string key)
        {
            throw new NotImplementedException();
        }
    }
}
