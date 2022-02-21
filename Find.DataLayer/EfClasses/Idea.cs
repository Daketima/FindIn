
using StatusGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public class Idea 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProjectAreaId { get; set; }
        public string ProposedCost { get; set; }
        public string EstimatedtimeLine { get; set; }
        public string DevelopmentTechnology { get; set; }
        public string ExpectedIncome { get; set; }
        public DateTime DateCreated { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovalComment { get; set; }
        public string DateApproved { get; set; }
        public string CompanyId { get; set; }        
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }



        public Idea() { }

        public IStatusGeneric<Idea> AddIdea()
        {
            var status = new StatusGenericHandler<Idea>();

            return status;
        }

        public IStatusGeneric<Idea> UpdateIdea()
        {
            var status = new StatusGenericHandler<Idea>();

            return status;
        }

        public IStatusGeneric<Idea> AddAnOffer()
        {
            var status = new StatusGenericHandler<Idea>();

            return status;
        }


    }
}
