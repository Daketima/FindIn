using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PermissionParts
{
    public static class PermissionPacker
    {
        public static string PackPermissionsIntoString(this IEnumerable<Permissions> permissons)
        {
            return permissons.Aggregate(",", (s, permission) => s + (char)permission);
        }

        public static IEnumerable<Permissions> UnpackpermissionsFromString(this string packedPermission)
        {
            if (packedPermission == null)
                throw new ArgumentNullException(nameof(packedPermission));
            foreach (var character in packedPermission)
            {
                yield return ((Permissions)character);
            }
        }

        public static Permissions? FindPermissionViaName(this string permissionName)
        {
            return Enum.TryParse(permissionName, out Permissions permission)
                ? (Permissions?)permission
                : null;
        }
    }
}
