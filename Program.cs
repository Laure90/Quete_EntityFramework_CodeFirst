using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quete_EntityFramework_Form
{
    static class Program
    {
        static void Main()
        {
            using (var context = new PersonContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var person = new Person
                {
                    Name = "Mr Richard"
                };

                person.savingAccountsList = new List<SavingAccount>
            {
                new SavingAccount { Amount = 2000000, BeginDate = Convert.ToDateTime("2020-01-02"), EndDate = Convert.ToDateTime("2020-08-30"), Rate = 0.05 },
                new SavingAccount { Amount = 250000, BeginDate = Convert.ToDateTime("2020-02-02"), EndDate = Convert.ToDateTime("2021-02-02") , Rate = 0.15  },
                new SavingAccount { Amount = 10000000, BeginDate = Convert.ToDateTime("2020-03-02"), EndDate = Convert.ToDateTime("2021-03-02"), Rate = 0.02  },
            };

                context.Add(person);
                context.SaveChanges();

                double amount = 0;
                double rate = 0;
                double result1 = 0;
                foreach (var currentAmount in person.savingAccountsList)
                {
                    amount = currentAmount.Amount;
                    rate = currentAmount.Rate;
                    result1 = SavingCalculator.CalculateTotalSaved(Convert.ToDateTime("2020-02-01"), Convert.ToDateTime("2021-05-30"), amount, rate);
                    MessageBox.Show(result1.ToString());

                }

            }
        }
    }
    
}
