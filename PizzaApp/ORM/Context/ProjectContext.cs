using PizzaApp.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ORM.Context
{
    internal class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            //Data Base bağlanma Entity Framework
            Database.Connection.ConnectionString = "Server=DESKTOP-H7CAIKT;Database=PizzaApp;uid=ASA;pwd=1071";
        }
        public DbSet<Kullanicilar> Kullanicilars { get; set; }
        public DbSet<Pizzalar> pizzalars { get; set; }
        public DbSet<Malzeme> malzemes { get; set; }
        //public DbSet<KullaniciTips> KullaniciTipis { get; set; }

        // Migration (Göç - Transfer)
        // enable-migrations
        // add-migration 'a'
        // update-database

    }
}
