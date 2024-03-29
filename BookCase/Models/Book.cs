﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookCase.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(10)]
        public string Isbn { get; set; }
        [Required]
        public string Title { get; set; }
        public string Genre { get; set; }
        
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PublishDate { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public Author Author { get; set; }

        [Required]
        public string OwnerId { get; set; }
        [Required]
        public ApplicationUser Owner { get; set; }

    }
}
