using System;

namespace PermissionParts
{
    [AttributeUsage(AttributeTargets.Field)]
    public class LinkedToModuleAttribute : Attribute
    {
        public PaidForModules PaidForModules { get; private set; }

        public LinkedToModuleAttribute (PaidForModules paidForModules)
        {
            PaidForModules = paidForModules;
        }
    }
}
