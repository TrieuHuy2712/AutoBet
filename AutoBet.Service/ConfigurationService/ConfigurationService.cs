using AutoBet.Data;
using AutoBet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Service.ConfigurationService
{
    public class ConfigurationService : IConfigurationService
    {
        private DatabaseContext context = new DatabaseContext();
        public ConfigurationService() { }
        public void AddConfiguration(InformationConfiguration information)
        {
            var newConfiguration = new InformationConfiguration
            {
                Position = information.Position,
                ProviderID = information.ProviderID,
                TableName = information.TableName,
                TypeOfChip = information.TypeOfChip,
                WidthHeight = information.WidthHeight,
                LocationPath = information.LocationPath
            };
            context.InformationConfiguration.Add(newConfiguration);
            context.SaveChanges();
        }

        public InformationConfiguration GetConfiguration(int ID)
        {
            return context.InformationConfiguration.FirstOrDefault(t => t.ID == ID);
        }

        public List<InformationConfiguration> GetListConfiguration()
        {
            return context.InformationConfiguration.ToList();
        }

        public List<Provider> GetListProvider()
        {
            return context.Providers.ToList();
        }

        public Provider GetProviderByName(string providerName)
        {
            return context.Providers.FirstOrDefault(t => t.ProviderName == providerName);
        }

        public List<InformationConfiguration> GetProviderName(string providerName, string tableName)
        {
            var providerID = GetProviderByName(providerName).ID;
            return context.InformationConfiguration.Where(t => t.ProviderID == providerID && t.TableName == tableName).ToList();
        }

        public void RemoveConfiguration(int ID)
        {
            var deletingConfiguration = GetConfiguration(ID);
            if (deletingConfiguration != null)
                context.InformationConfiguration.Remove(deletingConfiguration);

            context.SaveChanges();
        }

        public void UpdateConfiguration(InformationConfiguration information)
        {
            var config = GetConfiguration(information.ID);
            config.Position = information.Position;
            config.ProviderID = information.ProviderID;
            config.TableName = information.TableName;
            config.TypeOfChip = information.TypeOfChip;
            config.WidthHeight = information.WidthHeight;
            config.LocationPath = information.LocationPath;
            context.SaveChanges();
        }
    }
}
