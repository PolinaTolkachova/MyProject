using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Models
{
    public class Products
    {
        [Column("ProductID")]
        [Display(Name = "Product ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string ProductName { get; set; }

        [Display(Name = "Supplier ID")]
        public int SupplierID { get; set; }

        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Display(Name = "Quantity per unit")]
        public string QuantityPerUnit { get; set; }

        [Display(Name = "Unit price")]
        [Range(0, 999.99)]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Units in stock")]
        public short UnitsInStock { get; set; }

        [Display(Name = "Units on order")]
        public short UnitsOnOrder { get; set; }

        [Display(Name = "Reorder level")]
        [Range(0, 100)]
        public short ReorderLevel { get; set; }

        [Required]
        [Display(Name = "Discontinued")]
        public bool Discontinued { get; set; }
    }
}
