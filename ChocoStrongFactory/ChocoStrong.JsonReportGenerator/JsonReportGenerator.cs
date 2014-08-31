namespace ChocoStrong.JsonReportGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;


    using ChocoStrong.Model;
    using Newtonsoft.Json;

    public class JsonReportGenerator
    {
        public void GenerateReport(IEnumerable<Product> products)
        {
            if (products == null)
            {
                throw new NullReferenceException("products should not be null.");
            }

            var serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            foreach (Product product in products)
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Json-Reports\" + product.ProductId + @".js"))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, product);
                    }
                }
            }
        }
    }
}