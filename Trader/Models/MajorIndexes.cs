using Newtonsoft.Json;

namespace Trader.Domain.Models
{
    public class MajorIndexes
    {
        [JsonProperty("ResultSet")]
        public ResultSet? Result { get; set; }
    }
}
