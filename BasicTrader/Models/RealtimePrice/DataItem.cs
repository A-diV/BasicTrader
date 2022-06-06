namespace BasicTrader.Domain.Models.RealtimePrice
{
    public class DataItem
    {
        public string? Id { get; set; }
        public string? Type { get; set; }
        public Attribute? Attributes { get; set; }
        public Meta? Meta { get; set; }
    }
}
