using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChocoStrong.Model;

namespace ChocoStrong.ConsoleClient
{
    public class ChocoStrongSystem
    {
        private SalesReportImporter.SalesReportImporter mSalesImporter;
        private ProductsImporter.ProductsImporter mProductsImporter;

        public ChocoStrongSystem()
        {
            mSalesImporter = new SalesReportImporter.SalesReportImporter();
            mProductsImporter = new ProductsImporter.ProductsImporter();
        }

        public void DoStuff()
        {
            var importedShops = mProductsImporter.GetAllShops();
            var importedProducts = mProductsImporter.GetAllProducts();
            var importedSales = mSalesImporter.ImportAllSalesReports();

            var convertedCities = new Dictionary<string, City>();
            var convertedShops = new Dictionary<string, Shop>();
            var convertedProducts = new Dictionary<string, Product>();

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

                convertedShops.Add(importedShop.GetStringId(), shop);
            }

            foreach (var importedProduct in importedProducts)
            {
                var convertedProduct = new Product();
                convertedProduct.ProductName = importedProduct.ProductName;

                convertedProducts.Add(importedProduct.GetStringId(), convertedProduct);
            }

            foreach (var importedSale in importedSales)
            {
                var convertedSale = new Sale();
                convertedSale.Quantity = importedSale.Quantity;
                convertedSale.UnitPrice = importedSale.UnitPrice;
                convertedSale.Date = importedSale.SaleDate;
                convertedSale.Shop = convertedShops[importedSale.ShopName];
            }
        }
    }
}
