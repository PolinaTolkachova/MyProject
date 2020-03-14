using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Models
{
    public class Categories
    {
        [Column("CategoryID")]
        [Display(Name = "Category ID")]
        public int Id { get; set; }

        [Display(Name = "Category name")]
        public string CategoryName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
