using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceLayer.AccountController.QueryObject
{
    public enum UserFilterBy
    {
        [Display(Name = "All")]
        NoFilter = 0,
        [Display(Name = "By Name ascending")]
        ByNameAsc,
        [Display(Name = "By name descending")]
        ByNameDes
    }
    public class UserListDtoFilter
    {
    }
}
