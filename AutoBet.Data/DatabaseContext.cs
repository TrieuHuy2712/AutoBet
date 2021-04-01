using AutoBet.Data.Mapping;
using AutoBet.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<InformationConfiguration> InformationConfiguration { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DatabaseContext() : base(new SQLiteConnection()
        {
            ConnectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = "D:\\Databases\\AutoBet.db",
                ForeignKeys = true
            }.ConnectionString
        }, true)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new DieuKienMapping());
            modelBuilder.Configurations.Add(new ConfigurationMapping());
            modelBuilder.Configurations.Add(new ProviderMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
