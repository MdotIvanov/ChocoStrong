using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChocoStrong.Model;
using ChocoStrong.Data;

namespace ChocoStrong.ConsoleClient
{
    public class ChocoStrongSystem
    {
        private SalesReportImporter.SalesReportImporter mSalesImporter;
        private ProductsImporter.ProductsImporter mProductsImporter;

        private ChocoStrongDatabase mChocoStrongDb;

        public ChocoStrongSystem()
        {
            mSalesImporter = new SalesReportImporter.SalesReportImporter();
            mProductsImporter = new ProductsImporter.ProductsImporter();

            mChocoStrongDb = new ChocoStrongDatabase();
        }

        public void ImportProducts()
        {
            var importedShops = mProductsImporter.GetAllShops();
            var importedProducts = mProductsImporter.GetAllProducts();

            var convertedCities = new Dictionary<string, City>();
            var convertedShops = new Dictionary<string, Shop>();
            var convertedProducts = new Dictionary<string, Product>();

            var sampleCategory = new Category()
            {
                CategoryName = "sample category"
            };

            foreach (var importedShop in importedShops)
            {
                var importedCity = importedShop.City;
                City convertedCity = null;

                if (!convertedCities.TryGetValue(importedCity.CityName, out convertedCity))
                {
                    convertedCity = new City()
                    {
                        CityName = importedCity.CityName
                    };

                    convertedCities.Add(convertedCity.CityName, convertedCity);
                }

                Shop shop = new Shop();
                shop.ShopName = importedShop.ShopName;
                shop.Location = convertedCity;

                //convertedShops.Add(importedShop.GetStringId(), shop);
                convertedShops.Add(importedShop.ShopName, shop);
            }

            foreach (var importedProduct in importedProducts)
            {
                var convertedProduct = new Product();
                convertedProduct.ProductName = importedProduct.ProductName;
                convertedProduct.Category = sampleCategory;

                convertedProducts.Add(importedProduct.GetStringId(), convertedProduct);
            }

            foreach (var shop in convertedShops.Values)
            {
                mChocoStrongDb.Shops.Add(shop);
            }

            foreach (var product in convertedProducts.Values)
            {
                mChocoStrongDb.Products.Add(product);
            }

            mChocoStrongDb.Save();
        }

        public void ImportSales()
        {
            var importedSales = mSalesImporter.ImportAllSalesReports();
            var convertedSales = new List<Sale>();

            foreach (var importedSale in importedSales)
            {
                var convertedSale = new Sale();
                convertedSale.Quantity = importedSale.Quantity;
                convertedSale.UnitPrice = importedSale.UnitPrice;
                convertedSale.Date = importedSale.SaleDate;

                var shop = mChocoStrongDb.Shops.Find(s =>
                    s.ShopName == importedSale.ShopName &&
                    s.Location.CityName == importedSale.CityName);

                var product = mChocoStrongDb.Products.Find(p => 
                    p.ProductId == importedSale.ProductId);

                convertedSale.Shop = shop;
                convertedSale.SoldProduct = product;

                mChocoStrongDb.Sales.Add(convertedSale);
            }

            mChocoStrongDb.Save();
        }

        public void ImportExpenses()
        {

        }
    }
}
