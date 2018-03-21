using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyLibraryNew.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int TotalPages { get; set; }

        [Required]
        public string Author { get; set; }

        
        public int Progress { get; set; }

    }


}