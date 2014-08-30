using ChocoStrong.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChocoStrong.XmlReportGenerator
{
    public class XmlReportGenerator
    {
        private const string DateFormat = "dd-MM-YYYY";

        public bool GenerateReport(IEnumerable<Sale> sales)
        {
            bool isReportCreared = false;

            string fileName = "../../table.xml";
            Encoding encoding = Encoding.UTF8;
            var writer = new XmlTextWriter(fileName, encoding);
            
            using (writer)
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("sales");
                writer.WriteAttributeString("name", "Sales Report");
                
                foreach (var sale in sales)
	            {
		            WriteFile(writer, sale);
	            }

                isReportCreared = true;
            }

            Console.WriteLine("Document {0} has been created.", fileName);

            return isReportCreared;
        }

        private static void WriteFile(XmlWriter writer, Sale sale)
        {
            writer.WriteStartElement("sale");
            writer.WriteElementString("Shop Name", sale.Shop.ShopName);
            writer.WriteElementString("City Name", sale.Shop.Location.CityName);
            writer.WriteElementString("Product Name", sale.SoldProduct.ProductName);
            writer.WriteElementString("Quantity", (string)sale.Quantity);
            writer.WriteElementString("Unit Price", (string)sale.UnitPrice);
            writer.WriteElementString("Sale Date", sale.Date.ToString(DateFormat));
            writer.WriteEndElement();
        }

    }
}
