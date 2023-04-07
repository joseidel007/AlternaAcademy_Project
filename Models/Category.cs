using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace alterna_academy_project.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; } = null!;
        public string Description { get; set; } = null!;

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        //public virtual ICollection<Login> Logins { get; set; }
        //public Login Login { get; set;} = null!;
    }
}
