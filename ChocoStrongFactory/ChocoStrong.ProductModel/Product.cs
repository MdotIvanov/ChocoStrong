using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.ProductModel
{
    public class Product
    {
        [BsonId]
        public ObjectId ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal RecomendedPrice { get; set; }

        public Category Category { get; set; }

        [BsonConstructor]
        public Product(string productName, decimal recomendedPrice, Category category)
        {
            this.ProductName = productName;
            this.RecomendedPrice = recomendedPrice;
            this.Category = new Category() { CategoryName = category.CategoryName };
        }

        //public virtual Category Category { get; set; }

        public string GetStringId()
        {
            return this.ProductId.ToString();
        }
    }
}
