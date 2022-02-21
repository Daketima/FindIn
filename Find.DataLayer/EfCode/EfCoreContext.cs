using Find.DataLayer.EfClasses;
using Find.DataLayer.ExtraAuthClasses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Find.DataLayer.EfCode
{
    public class EfCoreContext : IdentityDbContext<IdentityUser>
    {
        public EfCoreContext(
            DbContextOptions<EfCoreContext> options)
            : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<UserToRole> UserToRole { get; set; }
        public DbSet<RoleToPermission> RoleToPermission { get; set; }
        public DbSet<ModulesForUser> UserModule  { get; set; }
        public DbSet<TimeStore> TimeStore { get; set; }
        public DbSet<Idea> Idea { get; set; }
        public DbSet<Offer> Offer { get; set; }


      

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new UserConfig());
            //builder.ApplyConfiguration(new UserRoleConfig());
            //builder.ApplyConfiguration(new RoleConfig());

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
