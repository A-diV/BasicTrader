namespace Trader.Domain.Models.AutoComplete
{
    public class AutoCompleteResult
    {
        public string? Symbol { get; set; }
        public string? Name { get; set; }
        public string? Exch { get; set; }
        public string? Type { get; set; }
        public string? ExchDisp { get; set; }
        public string? TypeDisp { get; set; }
    }
}
