using DataLayer.ExtraAuthClasses.Support;
using PermissionParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.ExtraAuthClasses
{
    /// <summary>
    /// This holds the modules a user has access to 
    /// </summary>
    public class ModulesForUser : IChangeEffectsUser, IAddRemoveEffectsUser
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="allowedPaidForModuled"></param>
        public ModulesForUser(string userId, PaidForModules allowedPaidForModuled)
        {
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            AllowedPaidForModules  = allowedPaidForModuled;
        }

        public string UserId { get; private set; }
        public PaidForModules AllowedPaidForModules { get; private set; }
    }
}
