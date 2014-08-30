using System;
using System.ComponentModel.DataAnnotations;

namespace ChocoStrong.Model
{
    // test commit asd
    // test comment
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public decimal RecomendedPrice { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
