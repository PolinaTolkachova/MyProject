using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Models
{
    public class Categories
    {
        [Column("CategoryID")]
        [Display(Name = "Category ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category name")]
        [StringLength(60, MinimumLength = 3)]
        public string CategoryName { get; set; }

        [Display(Name = "Description")]
        [StringLength(1000, MinimumLength = 3)]
        public string Description { get; set; }
    }
}
