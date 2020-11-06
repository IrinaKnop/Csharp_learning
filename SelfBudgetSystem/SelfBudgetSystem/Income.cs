using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBudgetSystem
{
    class Income : Capital
    {
        public Income(double amount, DateTime date, string category)
        {
            this.amount = amount;
            this.date = date;
            this.category = category;
        }
    }
}
