using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(18,4)")]
        public decimal UnitPrice { get; set; }
        [Required]
        public int StockQuantity { get; set; }
    }
}
