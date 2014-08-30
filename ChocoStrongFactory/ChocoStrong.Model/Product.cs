using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.Model
{
    //test commit asd
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal RecomendedPrice { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
