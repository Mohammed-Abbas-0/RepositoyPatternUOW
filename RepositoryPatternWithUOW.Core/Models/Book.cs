using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(200)]
        [Display(Name = "Book Title")]
        public string BookTitle { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
