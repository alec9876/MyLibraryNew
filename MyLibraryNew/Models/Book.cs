using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyLibraryNew.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int TotalPages { get; set; }
        public string Author { get; set; }
        public int Progress { get; set; }

    }


}