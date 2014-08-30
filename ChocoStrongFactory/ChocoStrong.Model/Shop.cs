using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.Model
{
    public class Shop
    {
        private ICollection<Sale> mSales;

        public Shop()
        {
            mSales = new HashSet<Sale>();
        }

        public int ShopId { get; set; }

        public string ShopName { get; set; }

        public virtual ICollection<Sale> Sales
        {
            get { return mSales; }
            set { mSales = value; }
        }

        public int LocationId { get; set; }

        public virtual City Location { get; set; }
    }
}
