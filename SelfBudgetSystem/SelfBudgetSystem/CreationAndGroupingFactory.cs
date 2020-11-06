using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBudgetSystem
{
    class CreationAndGroupingFactory
    {
        Income income;
        Consumption consumption;

        public void AcceptIncome(double amount, DateTime date, string category)
        {
            income = new Income(amount, date, category);
            CapitalRepository.GetRepository().Save(income);
        }
        public void AcceptConsumtion(double amount, DateTime date, string category)
        {
            consumption = new Consumption(amount, date, category);
            CapitalRepository.GetRepository().Save(consumption);
        }

    }
}
