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
        public bool GenerateReport()
        {
            bool isReportCreared = false;

            string fileName = "../../table.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            var writer = new XmlTextWriter(fileName, encoding);
            
            using (writer)
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();



            }



            return isReportCreared;
        }
    }
}
