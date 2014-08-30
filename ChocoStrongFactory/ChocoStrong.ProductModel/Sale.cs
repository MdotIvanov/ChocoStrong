using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.ProductModel
{
    public class Sale
    {
        public Sale(
            string shopName,
            string cityName,
            int productId,
            int quantity, 
            decimal unitPrice,
            DateTime saleDate)
        {
            this.ShopName = shopName;
            this.CityName = cityName;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.SaleDate = saleDate;
        }
        public string ShopName { get; set; }

        public string CityName { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public DateTime SaleDate { get; set; }

        public string GetStringId()
        {
            return this.ProductId.ToString();
        }
    }
}
