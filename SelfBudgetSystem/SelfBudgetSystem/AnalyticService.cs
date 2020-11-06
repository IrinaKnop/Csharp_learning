using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBudgetSystem
{
    class AnalyticService
    {
        public Analytic GetAnalytic()
        {
            Analytic analytic = new Analytic();
            Dictionary<string, List<Capital>> allCapitals = CapitalRepository.GetRepository().GetAll();
           
            foreach(List<Capital> capitals in allCapitals.Values)
            {
                foreach(Capital capital in capitals)
                {
                    if(capital is Income)
                    {
                        analytic.totalIncome += capital.amount;
                    }
                    else
                    {
                        analytic.totalConsumption += capital.amount;
                    }
                }
            }
            foreach (string category in allCapitals.Keys)
            {
                foreach (Capital capital in allCapitals[category])
                {
                    if (capital is Income)
                    {
                        analytic.sumIncomeByCategory(category, capital.amount);
                    }
                    else
                    {
                        analytic.sumConsumptionByCategory(category, capital.amount);
                    }
                }
            }
            return analytic;
        }
    }
}
