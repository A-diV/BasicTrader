using BasicTrader.Domain.Models.Enum;
using System.Threading.Tasks;

namespace Trader.Domain.Services
{
    public interface IAutoCompleteService<T> where T : class
    {
        Task<T> GetAutoCompleteResults(IndexType indexType);
    }
}
