using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLib
{
    public class BlogInfo
    {
        [Key]
        public int BlogId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Subject { get; set; }
        [Required]
        public DateTime DateOfCreation { get; set; }

        [Required]
        public string BlogUrl { get; set; }
        [EmailAddress]
        [Required]
        public string EmpEmailId { get; set; }
    }
}
