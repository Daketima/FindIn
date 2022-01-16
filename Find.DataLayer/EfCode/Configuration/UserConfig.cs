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
            // setup a shadow property of on the user entity class. 
            entity.Property<DateTime>("UpdatedOn")
                .HasColumnType("date");

            //Other configuration on the user entity class (table)
            
            entity.Property(p => p.DateCreated)
                .HasColumnType("date");
            entity.Property(p => p.UserId)
                .HasDefaultValueSql("NEWID()");
            entity.HasIndex(p => p.FirstName);
        }
    }
}
