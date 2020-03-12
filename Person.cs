using System;
using System.Collections.Generic;
using System.Text;

namespace Quete_EntityFramework_Form
{
    class Person
    {
        public Guid PersonID { get; set; }
        public string Name { get; set; }
        public List<SavingAccount> savingAccountsList { get; set; }
    }
}
