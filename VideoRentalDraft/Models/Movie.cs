using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentalDraft.Models
{
    public class Movie
    {
        [Key]

        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string DateTime { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string MovieLogo { get; set; }

    }
}