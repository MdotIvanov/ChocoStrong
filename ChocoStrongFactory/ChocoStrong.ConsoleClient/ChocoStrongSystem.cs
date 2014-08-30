using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var shops = mProductsImporter.GetAllShops();
            var products = mProductsImporter.GetAllProducts();
            var sales = mSalesImporter.ImportAllSalesReports();
        }
    }
}
