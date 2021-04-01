using AutoBet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBet.Application.Models
{

    public class AllTypeModel
    {
        public int IDType { get; set; }
        public InformationConfiguration betTypeModel { get; set; }
        public InformationConfiguration chipTypeModel { get; set; }
    }
}
