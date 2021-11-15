using Microsoft.EntityFrameworkCore;
using ServiceLayer.AccountController.QueryObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class SortFilterPageOptions
    {
        public const int DefaultPageSize = 10;  // this is the default page size, it is pegged at 10 rows per view

        /// <summary>
        /// this hold possible pages sizes
        /// </summary>
        public int[] PageSizes = new[] { 5, DefaultPageSize, 20, 50, 100, 500, 1000 };

        public OrderByOptions OrderByOptions { get; set; }

        public UserFilterBy FilterBy { get; set; }

        public string FilterValue { get; set; }

        //--------------------------------------
        // paging part, which require the user of the method


        public int PageNum { get; set; } = 1;

        public int PageSize { get; set; } = DefaultPageSize;

        /// <summary>
        /// This is set to the number of pages avaailable based on the number of intries in the query
        /// </summary>
        public int NumPages { get; set; }

        /// <summary>
        /// This holds the state of the key parts of the sortfilterpage parts
        /// </summary>
        public string PreviousCheckState { get; set; }

        public async Task SetupResttOfDto<T>(IQueryable<T> query)
        {
            NumPages = (int)Math.Ceiling((double)await query.CountAsync()) / PageSize;
            PageNum = Math.Min(Math.Max(1, PageNum), NumPages);

            var newCheckSate = GenerateCheckState();
            if (PreviousCheckState != newCheckSate)
                PageNum = 1;

            PreviousCheckState = newCheckSate;

        }

        //----------------------------------------
        //private methods

        /// <summary>
        /// This returns a string containing the state of the SortFilterPage data
        /// that, if they change, should cause the PageNum to be set back to 0
        /// </summary>
        /// <returns></returns>
        private string GenerateCheckState()
        {
            return $"{(int)FilterBy}{FilterValue},{PageSize},{NumPages}";
        }
    }
}
