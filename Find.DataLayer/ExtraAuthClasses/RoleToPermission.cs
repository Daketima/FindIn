using DataLayer.ExtraAuthClasses;
using DataLayer.ExtraAuthClasses.Support;
using Find.DataLayer.EfCode;
using PermissionParts;
using StatusGeneric;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Find.DataLayer.ExtraAuthClasses
{
   

    public class RoleToPermission : IChangeEffectsUser
    {
        public RoleToPermission() { } // ef core needs a default parameter less constructor

        public RoleToPermission(string roleName, string description, ICollection<Permissions> permissions)
        {
            RoleName = roleName;
            Update(description, permissions);
        }


        /// <summary>
        /// ShortName of the role
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(ExtraAuthConstants.RoleNameSize)]
        public string RoleName { get; private set; }

        [Required(AllowEmptyStrings = false)]
        private string _permissionsInRole; // A role must at least have a permission in it

        // <summary>
        /// A human-friendly description of what the Role does
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        public string Description { get; private set; }

        /// <summary>
        /// This returns the list of permissions in this role
        /// </summary>
        public IEnumerable<Permissions> PermissionsInRole => _permissionsInRole.UnpackpermissionsFromString();

        public static IStatusGeneric<RoleToPermission> CreateRoleWithPermissions(string roleName, string description, ICollection<Permissions> permissionInRole, ExtraAuthorizedDbContext context)
        {
            var status = new StatusGenericHandler<RoleToPermission>();
            if(context.Find<RoleToPermission>(roleName) != null)
            {
                status.AddError("That role already exists");
                return status;
            }
            return status.SetResult(new RoleToPermission(roleName, description, permissionInRole));
        }


        public void Update(string description, ICollection<Permissions> permissions)
        {
            if (permissions == null || !permissions.Any())
                throw new InvalidOperationException("There should be at least one permission associated with a role.");

            _permissionsInRole = permissions.PackPermissionsIntoString();
            Description = description;
        }

        public IStatusGeneric DeleteRole(string roleName, bool removeFromUsers, ExtraAuthorizedDbContext context)
        {
            var status = new StatusGenericHandler { Message = $"{nameof(roleName)} deleted successfull." };
            var roleToUpdate = context.Find<RoleToPermission>(roleName);

            if(roleToUpdate==null)
                return status.AddError($"{nameof(roleName)} does not exist");

            var usersWithRole = context.UserToRole.Where(x => x.RoleName == roleName).ToList();

            if (!usersWithRole.Any())
            {
                if (!removeFromUsers)
                    return status.AddError($"There are {usersWithRole.Count} with {nameof(roleName)} you are about to delete. Kindly update the concerned user before deleting this role");

                context.RemoveRange(usersWithRole);
                status.Message = $"Removed role from {usersWithRole.Count} user and then deleted role successfully.";
            }

            context.Remove(roleToUpdate);
            return status;
        }

    }
}
