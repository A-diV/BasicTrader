namespace BasicTrader.Domain.Models.RealtimePrice
{
    public class Meta
    {
        public string? Price { get; set; }
        public string? Volume24usd { get; set; }
        public char Symbol { get; set; }
        public string? Marketcap { get; set; }
        public string? Supply { get; set; }
        public double? MarketcapValue { get; set; }
        public string? High24 { get; set; }
        public double? SupplyValue { get; set; }
        public double? Volume24 { get; set; }
        public decimal? Volume24Value { get; set; }
        public string? Low24 { get; set; }
    }
}
