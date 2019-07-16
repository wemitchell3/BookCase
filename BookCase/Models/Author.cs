using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookCase.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string PenName { get; set; }
        public string Genre { get; set; }
        public List<Book> Books { get; set; }

        //Not mapped is so that a column is not add during a migration
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
