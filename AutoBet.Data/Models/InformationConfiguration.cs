using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Data.Models
{
    public class InformationConfiguration
    {
        public int ID { get; set; }
        // Foreign key
        public int ProviderID { get; set; }
        public string TableName { get; set; }
        public int TypeOfChip { get; set; }
        public string Position { get; set; }
        public string WidthHeight { get; set; }
        public string LocationPath { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
