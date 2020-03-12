using System;
using System.Collections.Generic;
using System.Text;

namespace Quete_EntityFramework_Form
{
    class SavingCalculator
    {
        public static double CalculateTotalSaved(DateTime begin, DateTime end, double amount, double rate)
        {

            int months = (end - begin).Days / 28;
            int years = (end - begin).Days / 365;
            double valueRate = 0;
            double totalValueRate = 0;

            if (rate == 0.05)
            {
                for (int i = 1; i <= months; i++)
                {
                    valueRate = amount * rate;
                    totalValueRate = totalValueRate + valueRate;
                }
            }
            if (rate == 0.15 || rate == 0.02)
            {
                for (int i = 1; i <= years; i++)
                {
                    valueRate = amount * rate;
                    totalValueRate = totalValueRate + valueRate;
                }
            }
            return totalValueRate;
        }
    }
}
