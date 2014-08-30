using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChocoStrong.ProductModel;
using ChocoStrong.ProductsImporter;
using ChocoStrong.SalesReportImporter;

using ChocoStrong.Model;
using ChocoStrong.Data;

namespace ChocoStrong.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ChocoStrongSystem();
            client.DoStuff();
        }
    }
}
