using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChocoStrong.XmlImporter
{
    public class XmlImporter
    {
        public void ReadReport()
        {
            string fileName = "../../xmlFile.xml";
            var reader = XmlReader.Create(fileName);

            using (reader)
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "Shop Name"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }

            using (reader)
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        Console.WriteLine(reader.Name);
                    }
                }
            }

        }
    }
}
