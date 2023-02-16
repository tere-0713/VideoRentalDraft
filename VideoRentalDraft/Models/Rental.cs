using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentalDraft.Models
{
    public class Rental
    {
        [Key]

        public int RentalId { get; set; }
        public string RentalDate { get; set; }
        public string CustomerId { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }
        public string MovieId { get; set; }

    }
}