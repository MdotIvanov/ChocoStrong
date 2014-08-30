using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        public string ShopName { get; set; }

        public virtual ICollection<Sale> Sales
        {
            get { return mSales; }
            set { mSales = value; }
        }

        public int LocationId { get; set; }

        [Required]
        public virtual City Location { get; set; }
    }
}
