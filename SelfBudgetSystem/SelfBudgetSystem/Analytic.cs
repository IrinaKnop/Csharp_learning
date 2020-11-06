using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBudgetSystem
{
    class Analytic
    {
        public double totalIncome;
        public double totalConsumption;
        public Dictionary<string, double> incomeByCategory;
        public Dictionary<string, double> comsumptionByCategory;

        public Analytic()
        {
            totalIncome = 0.0;
            totalConsumption = 0.0;
            incomeByCategory = new Dictionary<string, double>();
            comsumptionByCategory = new Dictionary<string, double>();
        }

        public void sumIncomeByCategory(string category, double addAmount)
        {
            if (!incomeByCategory.TryGetValue(category, out _))
            {
                incomeByCategory[category] = new double();
            }
            incomeByCategory[category] += addAmount;
        }

        public void sumConsumptionByCategory(string category, double addConsumption)
        {
            if (!comsumptionByCategory.TryGetValue(category, out _))
            {
                comsumptionByCategory[category] = new double();
            }
            comsumptionByCategory[category] += addConsumption;
        }

        public override string ToString()
        {
            string result = "";
            result += "Общая сумма доходов: " + totalIncome + "\n";
            result += "Доходы по категориям: \n";
            foreach (string category in incomeByCategory.Keys)
            {
                result += category + ": " + incomeByCategory[category] + "\n";
            }
            result += "Общая сумма расходов: " + totalConsumption + "\n";
            result += "Расходы по категориям: \n";
            foreach (string category in comsumptionByCategory.Keys)
            {
                result += category + ": " + comsumptionByCategory[category] + "\n";
            }
            result += "Остаток средств: " + (totalIncome - totalConsumption);
            return result;
        }
    }
}
