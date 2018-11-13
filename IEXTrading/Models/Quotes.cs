using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEXTrading.Models
{

    public class SymbolQuote
    {
        public Dictionary<string, Quote> quote { get; set; }
    }

    public class Quote
    {
        public float? 52_week_price { get; set; }// To calculate 52-week Price Range for picking top 5 stocks
        public string symbol { get; set; }
        public string name_company { get; set; }
        public string exchange_primary { get; set; }
        public string sector { get; set; }
        public string price_calculated { get; set; }
        public float? open { get; set; }
        public long? time_open { get; set; }
        public float? close { get; set; }
        public long? time_close { get; set; }
        public float? high { get; set; }
        public float? low { get; set; }
        public float? price_latest { get; set; }
        public string source_latest { get; set; }
        public string time_latest { get; set; }
        public long? update_latest { get; set; }
        public long? volume_latest { get; set; }
        public float? iex_dynamic_price { get; set; }
        public long? iex_dynamic_time { get; set; }
        public string iex_lastrefresh { get; set; }
        public float? price_delayed { get; set; }
        public long? time_pricedelayed { get; set; }
        public float? price_extended { get; set; }
        public float? change_extended { get; set; }
        public float? change_extendedpercent { get; set; }
        public long? pricetime_extended { get; set; }
        public float? clode_previous { get; set; }
        public float? change { get; set; }
        public float? Percent_change { get; set; }
        public float? iexmark_percent { get; set; }
        public long? iex_volume { get; set; }
        public float? avg_total_volume { get; set; }
        public float? iex_bid_price { get; set; }
        public long? iex_bid_size { get; set; }
        public float? iex_ask_price { get; set; }
        public long? iex_ask_size { get; set; }
        public float? market_cap { get; set; }
        public float? pe_ratio { get; set; }
        public float? week52_high { get; set; }
        public float? week52_low { get; set; }
        public float? change_ytd { get; set; }


    }

}