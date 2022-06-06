using Newtonsoft.Json;
using System.Collections.Generic;

namespace BasicTrader.Domain.Models.RealtimePrice
{
    public class RealtimeData
    {
        /// <summary>
        /// Root element of JSON file - response from YAHOO API.
        /// </summary>
        [JsonProperty("data")]
        public List<DataItem>? Data { get; set; }
    }
}
