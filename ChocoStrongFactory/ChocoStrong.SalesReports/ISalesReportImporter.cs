﻿using ChocoStrong.ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.SalesReportImporter
{
    interface ISalesReportImporter
    {
        ICollection<Sale> ImportAllSalesReports();
    }
}
