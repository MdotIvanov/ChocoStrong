using ChocoStrong.ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.ProductsImporter
{
    public class ProductsImporter : IProductsImporter
    {
        public ICollection<Product> GetAllProducts()
        {
            var Mocked = new List<Product>
            {
                new Product("test Product", 15.50m, new Category(){ CategoryName = "test category"}),
            };
            return Mocked;
        }


        public ICollection<Shop> GetAllShops()
        {
            var Mocked = new List<Shop>
            {
                new Shop("test shop", new City{CityName = "Sofia"}),
                new Shop("test shop 2", new City{CityName = "Plovdiv"}),
                new Shop("test shop 3", new City{CityName = "Varna"}),
            };
            return Mocked;
        }
    }
}
