﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //[ForeignKey("Author")]
        //public int AuthorId { get; set; }

        //public Author? Author { get; set; }

    }
}
