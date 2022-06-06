using System.Threading.Tasks;

namespace Trader.Domain.Services
{
    public interface IAutoCompleteService<T> where T : class
    {
        Task<T> GetAutoCompleteResults(string indexType);
    }
}
