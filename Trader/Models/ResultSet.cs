using Newtonsoft.Json;
using System.Collections.Generic;

namespace Trader.Domain.Models
{
    public class ResultSet
    {
        [JsonProperty("Result")]
        public List<MajorIndex>? Result { get; set; }

        [JsonProperty("Query")]
        public string? Query { get; set; }
    }

}
