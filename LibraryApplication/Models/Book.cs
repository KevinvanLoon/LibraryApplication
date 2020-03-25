using System;
using System.Collections.Generic;

namespace LibraryApplication.Models
{
    public partial class Book
    {
        public Book()
        {
            Loans = new HashSet<Loan>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Writer { get; set; }
        public string Language { get; set; }
        public int? Edition { get; set; }
        public int? Pages { get; set; }
        public bool? Illustraties { get; set; }
        public string Isbn { get; set; }

        public virtual ICollection<Loan> Loans { get; set; }
    }
}
