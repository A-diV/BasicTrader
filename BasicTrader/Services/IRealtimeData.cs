using BasicTrader.Domain.Models.Enum;
using System.Threading.Tasks;

namespace BasicTrader.Domain.Services
{
    public interface IRealtimeData<T> where T : class
    {
        Task<T> GetRealTimePrices(IndexType indexType);
    }
}
