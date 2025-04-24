using System.ComponentModel.DataAnnotations;

namespace SingularProductApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public string SalePrice { get; set; } = "";
        public string Category { get; set; } = "";
        public string Image { get; set; } = "";
    }
}
