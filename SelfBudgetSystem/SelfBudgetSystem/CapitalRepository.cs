using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBudgetSystem
{
    //На данном этапе class CapitalRepository заменяет БД доходов и расходов без реализации хранения данных
    class CapitalRepository 
    {
        private static CapitalRepository repository;
        private Dictionary<string, List<Capital>> incomeAndConsumption;
        private CapitalRepository()
        {
            incomeAndConsumption = new Dictionary<string, List<Capital>>();
            
        }
        public static CapitalRepository GetRepository()
        {
            if (repository == null)
            {
                repository = new CapitalRepository();
            }
            return repository;
        }

        public Dictionary<string, List<Capital>> GetAll()
        {
            return incomeAndConsumption;
        }

        public void Save(Capital capital)
        {
            if (!incomeAndConsumption.TryGetValue(capital.category, out _))
            {
                incomeAndConsumption[capital.category] = new List<Capital>();
            }
            incomeAndConsumption[capital.category].Add(capital);
        }                
    }
}
