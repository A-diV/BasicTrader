using Newtonsoft.Json;

namespace Trader.Domain.Models.AutoComplete
{
    public class AutoComplete
    {
        /// <summary>
        /// Root element of JSON file - response from YAHOO API.
        /// </summary>
        [JsonProperty("ResultSet")]
        public ResultSet? Result { get; set; }
    }
}
