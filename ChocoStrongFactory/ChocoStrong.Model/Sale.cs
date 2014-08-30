using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.Model
{
    public class Sale
    {
        public int SaleId { get; set; }

        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }

        public int ProductId { get; set; }

        public virtual Product SoldProduct { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
