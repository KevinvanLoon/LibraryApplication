using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryApplication.Models
{
    public partial class Loan
    {
        public int Id { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
