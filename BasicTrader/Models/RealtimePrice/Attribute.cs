using System;
using System.Text.Json.Serialization;

namespace BasicTrader.Domain.Models.RealtimePrice
{
    public class Attribute
    {
        public string? Identifier { get; set; }
        public string? Name { get; set; }
        public decimal Last { get; set; }
        public decimal Change { get; set; }
        public decimal PercentChange { get; set; }
        public decimal PreviousCose { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Volume { get; set; }
        public DateTime DateTime { get; set; }
        public string? QuoteInfo { get; set; }
        public decimal Close { get; set; }
        public decimal? ChangeFromPreviousClose { get; set; }
        public decimal? PercentChangeFromPreviousClose { get; set; }
        public decimal Low52Week { get; set; }
        public decimal High52Week { get; set; }
        [JsonIgnore]
        public decimal? ExtendedHoursPrice { get; set; }
        [JsonIgnore]
        public string? ExtendedHoursChange { get; set; }
        [JsonIgnore]
        public decimal? ExtendedHoursPercentChange { get; set; }
        [JsonIgnore]
        public string? ExtendedHoursDateTime { get; set; }
        [JsonIgnore]
        public string? ExtendedHoursType { get; set; }
        public string? SourceAPI { get; set; }
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
    }
}
