using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Data.Models
{
    public class Provider
    {
        public int ID { get; set; }
        public string ProviderName { get; set; }
        public virtual ICollection<InformationConfiguration> InformationConfigurations { get; set; }
    }
}
