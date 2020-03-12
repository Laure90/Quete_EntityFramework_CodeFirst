using System;
using System.Collections.Generic;
using System.Text;

namespace Quete_EntityFramework_Form
{
    class SavingAccount
    {
        public Guid SavingAccountID { get; set; }
        public double Amount { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Rate { get; set; }
        public Person Person { get; set; }
    }
}
