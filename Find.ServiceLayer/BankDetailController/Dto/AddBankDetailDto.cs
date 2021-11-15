using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.BankDetailController.Dto
{
   public class AddBankDetailDto
    {       

        
        public int BankDetailId { get; set; }
        public Guid UserId { get; set; }

        public string BankName { get; set; }

        public string AccountNumber { get; set; }

        public decimal AcccountBalance { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateAdded { get; set; }


        //------------Relationship ------------
       // public User User { get; set; }
    }
}
