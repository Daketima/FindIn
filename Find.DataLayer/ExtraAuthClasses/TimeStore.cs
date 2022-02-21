using RefreshClaimsParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Find.DataLayer.ExtraAuthClasses
{
    
    public class TimeStore
    {
        [Key]
        [Required]
        [MaxLength(AuthChangesConsts.CacheKeyMaxSize)]
        public string key { get; set; }
        public long LastUpdateTicks { get; set; }
    }
}
