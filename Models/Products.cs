using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Models
{
    public class Products
    {
        [Column("ProductID")]
        [Display(Name = "Product ID")]
        public int Id { get; set; }

        [Display(Name = "Product name")]
        public string ProductName { get; set; }

        [Display(Name = "Supplier ID")]
        public int SupplierID { get; set; }

        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Display(Name = "Quantity per unit")]
        public string QuantityPerUnit { get; set; }

        [Display(Name = "Unit price")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Units in stock")]
        public short UnitsInStock { get; set; }

        [Display(Name = "Units on order")]
        public short UnitsOnOrder { get; set; }

        [Display(Name = "Reorder level")]
        public short ReorderLevel { get; set; }

        public bool Discontinued { get; set; }
    }
}
