using AutoBet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Service.ConfigurationService
{
    public interface IConfigurationService
    {
        Provider GetProviderByName(string providerName);
        List<InformationConfiguration> GetProviderName(string providerName, string tableName);
        List<Provider> GetListProvider();
        List<InformationConfiguration> GetListConfiguration();
        InformationConfiguration GetConfiguration(int ID);
        void AddConfiguration(InformationConfiguration information);
        void UpdateConfiguration(InformationConfiguration information);
        void RemoveConfiguration(int ID);
    }
}
