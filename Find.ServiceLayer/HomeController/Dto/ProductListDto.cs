using Find.DataLayer.EfClasses;
using GenericServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.HomeController.Dto
{
   public class ProductListDto : ILinkToEntity<object>
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
