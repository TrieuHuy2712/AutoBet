using AutoBet.Application;
using AutoBet.Data.Enums;
using System;
using System.Collections.Generic;

namespace AutoBet.Data.Models
{
    public class ConditionCommand
    {
        public List<BetType> TypeWin { get; set; }
        public BetType Bet { get; set; }
        public ConfigurationEnum ChipType { get; set; }
        public int NumberImplement { get; set; }
        public bool isNegative { get; set; }
    }
}
