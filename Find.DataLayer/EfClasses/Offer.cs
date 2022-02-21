using Find.DataLayer;
using StatusGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public class Offer 
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string IdeaId { get; set; }
        public string Proposal { get; set; }
        public DateTime DateCreate { get; set; }
        public string Status { get; set; }
        public string IdeaOwnerComment { get; set; }

        public Offer()
        {

        }

        public IStatusGeneric<Offer> UpdateOffer()
        {
            var status = new StatusGenericHandler<Offer>();

            return status;
        }
    }
}
