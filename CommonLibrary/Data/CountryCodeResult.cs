﻿using Newtonsoft.Json;

namespace BetfairNG.Data
{
    public sealed class CountryCodeResult
    {
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty(PropertyName = "marketCount")]
        public int MarketCount { get; set; }
    }
}
