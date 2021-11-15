using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceLayer.AccountController.QueryObject
{
    public enum OrderByOptions
    {
        [Display(Name = "sort by...")]
        SimpleOrder = 0,
        //[Display(Name = "Votes ↑")]
        //ByVotes,
        [Display(Name = "Publication Date ↑")]
        ByAddedDate,
        //[Display(Name = "Price ↓")]
        //ByPriceLowestFirst,
        //[Display(Name = "Price ↑")]
        //ByPriceHigestFirst

    }
    
   public class UserListDto
    {
    }
}
