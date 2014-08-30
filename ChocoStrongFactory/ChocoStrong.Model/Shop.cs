using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChocoStrong.Model
{
    public class Shop
    {
        private ICollection<Sale> mSales;
        private ICollection<LogisticExpense> mLogisticExpenses;

        public Shop()
        {
            mSales = new HashSet<Sale>();
            mLogisticExpenses = new HashSet<LogisticExpense>();
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

        public virtual ICollection<LogisticExpense> LogisticExpenses
        {
            get { return mLogisticExpenses; }
            set { mLogisticExpenses = value; }
        }
    }
}
