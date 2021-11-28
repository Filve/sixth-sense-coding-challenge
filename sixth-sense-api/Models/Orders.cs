using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sixth.sense.api.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string CompanyCode { get; set; }
        public IEnumerable<OrderedProducts> OrderedProducts { get; set; }
    }

    public class OrderedProducts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int OrderedQuantity { get; set; }
    }
}
