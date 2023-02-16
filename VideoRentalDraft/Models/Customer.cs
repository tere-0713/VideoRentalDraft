using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentalDraft.Models
{
    public class Customer
    {
        [Key]

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string TransactionNumber { get; set; }
        public string RentalId { get; set; }


    }
}