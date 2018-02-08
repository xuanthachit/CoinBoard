using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinBoard.Models
{
    public class TickerViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Rank { get; set; }
        public string PriceUsd { get; set; }
        public string PriceBtc { get; set; }
        public string InvalidNameVolumeUsd { get; set; }
        public string MarketCapUsd { get; set; }
        public string AvailableSupply { get; set; }
        public string TotalSupply { get; set; }
        public string PercentChangeOneH { get; set; }
        public string PercentChangeTFH { get; set; }
        public string PercentChangeSevenD { get; set; }
        public string LastUpdated { get; set; }
    }
}