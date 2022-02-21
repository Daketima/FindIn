using Find.DataLayer.EfClasses;
using Find.DataLayer.ExtraAuthClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfCode.Configuration
{
    public class UserToRoleConfig : IEntityTypeConfiguration<UserToRole>
    {
        public void Configure(EntityTypeBuilder<UserToRole> entity)
        {
            entity.HasKey(p => new { p.UserId, p.RoleName });          
                
        }
    }
}
