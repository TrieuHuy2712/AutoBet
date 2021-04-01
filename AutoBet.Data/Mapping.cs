using AutoBet.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Data.Mapping
{
    public class DieuKienMapping: EntityTypeConfiguration<Condition>
    {
        public DieuKienMapping()
        {
            ToTable("Condition");
            Property(p => p.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ConditionContent);
            Property(p => p.ConditionTitle);

        }
    }

    public class ConfigurationMapping : EntityTypeConfiguration<InformationConfiguration>
    {
        public ConfigurationMapping()
        {
            ToTable("Configuration");
            Property(p => p.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Position);
            Property(p => p.ProviderID);
            Property(p => p.TableName);
            Property(p => p.TypeOfChip);
            Property(p => p.WidthHeight);
            Property(p => p.LocationPath);
            HasRequired(c => c.Provider).WithMany(d => d.InformationConfigurations).HasForeignKey(c => c.ProviderID);
        }
    }

    public class ProviderMapping : EntityTypeConfiguration<Provider>
    {
        public ProviderMapping()
        {
            ToTable("Provider");
            Property(p => p.ID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ProviderName);
        }
    }
}
