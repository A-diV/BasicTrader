using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trader.Domain.Models.AutoComplete
{
    public class ResultSet
    {
        /// <summary>
        /// Child elements of JSON root element. Result is an array of items in JSON file.
        /// </summary>
        [JsonProperty("Result")]
        public List<AutoCompleteResult>? Result { get; set; }

        [JsonProperty("Query")]
        public string? Query { get; set; }
    }

}
