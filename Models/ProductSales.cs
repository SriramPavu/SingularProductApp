using System.ComponentModel.DataAnnotations;

namespace SingularProductApp.Models
{
    public class ProductSales
    {
        public int SaleId { get; set; }
        public string ProductId { get; set; } = "";
        public decimal SalePrice { get; set; }
        public decimal SaleQty { get; set; }
        public DateTime SaleDate { get; set; } 
    }
}
