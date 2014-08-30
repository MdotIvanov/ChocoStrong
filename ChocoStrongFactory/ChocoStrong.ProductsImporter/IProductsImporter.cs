using ChocoStrong.ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChocoStrong.ProductsImporter
{
    interface IProductsImporter
    {
        ICollection<Product> GetAllProducts();
        ICollection<Shop> GetAllShops();
    }
}
