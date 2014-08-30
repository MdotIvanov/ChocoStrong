using System;
using System.ComponentModel.DataAnnotations;

namespace ChocoStrong.Model
{
    public class Sale
    {
        public int SaleId { get; set; }

        public int ShopId { get; set; }

        [Required]
        public virtual Shop Shop { get; set; }

        public int ProductId { get; set; }

        [Required]
        public virtual Product SoldProduct { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
