using System.Threading.Tasks;

namespace Trader.Domain.Services
{
    public interface IMajorIndexService<T> where T : class
    {
        Task<T> GetMajorIndex(string indexType);
    }
}
