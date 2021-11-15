using Find.DataLayer.EfClasses;
using Find.DataLayer.EfCode.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Find.DataLayer.EfCode
{
    public class EfCoreContext : DbContext
    {
        public EfCoreContext(
            DbContextOptions<EfCoreContext> options)
            : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<MaritalStatus> MaritalStatus { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfig());
            builder.ApplyConfiguration(new UserRoleConfig());
        }
    }
}
