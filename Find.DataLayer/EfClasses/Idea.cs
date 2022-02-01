using Find.DataLayer.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Find.DataLayer.EfClasses
{
    public class Idea : Entity
    {       
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProjectAreaId { get; set; }
        public string ProposedCost { get; set; }
        public string ProposedtimeLine { get; set; }
        public string DevelopmentTech { get; set; }
        public string ExpectedIncome { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovalComment { get; set; }
        public string DateApproved { get; set; }
        public string CompanyId { get; set; }
        public string StatusId { get; set; }
        

        public Idea() { }
    }
}
