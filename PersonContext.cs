using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Quete_EntityFramework_Form
{
    class PersonContext : DbContext
    {
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }
        public virtual DbSet<Person> People { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=BanqueQuete;Integrated Security=True");
        }
    }
}
