using ChocoStrong.ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.SalesReportImporter
{
    public class SalesReportImporter : ISalesReportImporter
    {

        public ICollection<Sale> ImportAllSalesReports()
        {
            var Mocked = new List<Sale>()
            {
                new Sale("test shop", "Sofia", 1, 10, 10.0M, DateTime.Now),
                new Sale("test shop 2", "Plovdiv", 1, 10, 10.0M, DateTime.Now),
                new Sale("test shop 3", "Varna", 1, 10, 10.0M, DateTime.Now),
            };

            return Mocked;

            
        }
    }
}
