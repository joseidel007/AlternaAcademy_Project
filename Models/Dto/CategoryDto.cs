using System.ComponentModel.DataAnnotations;

namespace alterna_academy_project.Models.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; }
    }
}
