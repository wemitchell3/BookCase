using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookCase.Models
{
    public class ApplicationUser : IdentityUser
    {   
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        //Not mapped is so that a column is not add during a migration
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

    }
}
