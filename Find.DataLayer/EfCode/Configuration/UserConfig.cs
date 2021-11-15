using Find.DataLayer.EfClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfCode.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.Property(p => p.DateCreated)
                .HasColumnType("date");           

            entity.HasIndex(p => p.FirstName);
        }
    }
}
