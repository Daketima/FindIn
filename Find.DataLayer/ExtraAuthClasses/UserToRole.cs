using DataLayer.ExtraAuthClasses;
using Find.DataLayer.EfCode;
using StatusGeneric;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Find.DataLayer.ExtraAuthClasses
{
    /// <summary>
    /// This is a one-to-many relationship between the user (represented by the userId) and theirs roles ( represented by RoleToPermissions)
    /// </summary>
    public class UserToRole
    {
        public UserToRole() { } // ef core needs defauld constructor for domain class that will form the tables in the db


        public UserToRole(string userId, RoleToPermission role)
        {
            UserId = userId;
            Role = role;
        }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(ExtraAuthConstants.UserIdSize)]
        public string UserId { get; private set; }
        public RoleToPermission Role { get; private set; }
        [ForeignKey(nameof(RoleName))]
        public string RoleName { get; private set; }

        public static IStatusGeneric<UserToRole> AddRoleToUser(string userId, string roleName, ExtraAuthorizedDbContext context)
        {
            if (roleName == null) throw new ArgumentNullException(nameof(roleName));

            var status = new StatusGenericHandler<UserToRole>();

            if (context.Find<UserToRole>(userId, roleName) != null)
            {
                status.AddError($"The user already has the role '{roleName}'.");
                return status;
            }

            var roleToAdd = context.Find<RoleToPermission>(roleName);
            if (roleToAdd == null)
            {
                status.AddError($"Unable to find role '{roleName}'.");
                return status;
            }

            return status.SetResult(new UserToRole(userId, roleToAdd));
        }

    }
}
