using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoRentalDraft.Models
{
    public class User
    {
        [Key]

        public int UserManagement { get; set; }
        public string UserId { get; set; }
        public string UserManagementId { get; set; }

        [Key]

        public int LogIn { get; set; }
        public string LogInId { get; set; }


    }
}