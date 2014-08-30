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
                new Sale("ASD shop Name", "ASD CityName", 1, 10, 10.0M, DateTime.Now),
                new Sale("ASD shop Name2", "ASD CityName", 1, 10, 10.0M, DateTime.Now),
                new Sale("ASD shop Name3", "ASD CityName", 1, 10, 10.0M, DateTime.Now),
                new Sale("ASD shop Name4", "ASD CityName", 1, 10, 10.0M, DateTime.Now),
            };

            return Mocked;

            
        }
    }
}
