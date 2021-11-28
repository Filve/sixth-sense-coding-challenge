using System.ComponentModel.DataAnnotations;

namespace sixth.sense.api.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int StockQuantity { get; set; }
    }
}
