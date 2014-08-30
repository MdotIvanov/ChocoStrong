using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoStrong.Model
{
    public class LogisticExpense
    {
        public int ExpenseId { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
    }
}