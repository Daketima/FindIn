using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PermissionParts
{
    public enum Permissions : short
    {
        NotSet = 0, // error conditior

        [Display(GroupName = "IdeaOwner", Name = "Add New", Description ="Can add an idea")]
        IdeaAdd = 1,

        [Display(GroupName = "IdeaOwner", Name = "Read", Description = "Can add an idea")]
        IdeaViewOwn = 11,

        [Display(GroupName = "IdeaOwner", Name = "Read Ideas", Description = "Can add an idea")]
        IdeaViewAll = 12,

        [Display(GroupName = "AdminUser", Name = "Read All Ideas", Description = "Can add an idea")]
        IdeaViewOthers = 12,

        [Display(GroupName = "Investor", Name = "Add New", Description = "Allows a user to add an offer to the system")]
        InvestorAddOffer = 2,

        [Display(GroupName = "Investor", Name = "Read", Description = "Allows a user to add an offer to the system")]
        InvestorViewOwnOffer = 21,

        [Display(GroupName = "CacheTest", Name = "Cache1", Description = "Base permission to update permission test")]
        Cache1 = 60,
        [Display(GroupName = "CacheTest", Name = "Cache2", Description = "Permission to toggle for update permission test")]
        Cache2 = 61,

        [Display(GroupName = "Impersonation", Name = "Impersonate - straight", Description = "Impersonate user using their permissions")]
        Impersonate = 70,
        [Display(GroupName = "Impersonation", Name = "Impersonate - enhanced", Description = "Impersonate user using current permissions")]
        ImpersonateKeepOwnPermissions = 71,

        //This is an example of what to do with permission you don't used anymore.
        //You don't want its number to be reused as it could cause problems 
        //Just mark it as obsolete and the PermissionDisplay code won't show it
        [Obsolete]
        [Display(GroupName = "Old", Name = "Not used", Description = "example of old permission")]
        OldPermissionNotUsed = 100,

        //This is an example of a permission linked to a optional (paid for?) feature
        //The code that turns roles to permissions can
        //remove this permission if the user isn't allowed to access this feature
        [LinkedToModule(PaidForModules.FeatureOne)]
        [Display(GroupName = "Features", Name = "Feature1", Description = "Can access feature1")]
        Feature1Access = 1000,
        [LinkedToModule(PaidForModules.FeatureTwo)]
        [Display(GroupName = "Features", Name = "Feature2", Description = "Can access feature2")]
        Feature2Access = 1001,

        [Display(GroupName = "UserAdmin", Name = "AccessAll", Description = "This give the user right to access all features and permission")]
        AccessAll = 1001

        



        

        
    }
}
