namespace ChocoStrong.JsonReportGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    using ChocoStrong.Model;
    using Newtonsoft.Json;

    public class JsonReportGenerator
    {
        public void GenerateReport(IEnumerable<Sale> sales)
        {
            string json = JsonConvert.SerializeObject(product);
        }
    }
}