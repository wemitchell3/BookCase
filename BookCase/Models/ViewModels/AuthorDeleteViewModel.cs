using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCase.Models.ViewModels
{
    public class AuthorDeleteViewModel
    {
        public Author Author { get; set; }

        public bool CanDelete { get; set; }
    }
}
