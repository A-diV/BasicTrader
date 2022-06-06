namespace Trader.Domain.Models
{
    public enum MajorIndexType
    {
        DowJones,
        Nasdaq,
        SP500
    }

    public class MajorIndex
    {

        public string? Symbol { get; set; }
        public string? Name { get; set; }
        public string? Exch { get; set; }
        public string? Type { get; set; }
        public string? ExchDisp { get; set; }
        public string? TypeDisp { get; set; }

    }
}
