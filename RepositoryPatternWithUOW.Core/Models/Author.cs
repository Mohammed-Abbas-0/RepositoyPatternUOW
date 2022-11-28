using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(200)]
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }
    }
}
