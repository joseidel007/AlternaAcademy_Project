using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace alterna_academy_project.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }


        [MinLength(5)]
        [MaxLength(15)]
        public string Username { get; set; } = null!;

        [MinLength(10)]
        [MaxLength(25)]
        public string Password { get; set; } = null!;

        [MinLength(5)]
        [MaxLength(100)]
        public string WebSite { get; set; } = null!;

        [MinLength(0)]
        [MaxLength(250)]
        [AllowNull]
        public string Notes { get; set; }


        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}

        //[ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

    }
}
