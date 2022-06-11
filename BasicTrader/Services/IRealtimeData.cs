using BasicTrader.Domain.Models.Enum;
using BasicTrader.Domain.Models.RealtimePrice;
using System.Threading.Tasks;

namespace BasicTrader.Domain.Services
{
    public interface IRealtimeData//<T> where T : class
    {
        Task<RealtimeData> GetRealTimePrices(IndexType indexType);
    }
}
