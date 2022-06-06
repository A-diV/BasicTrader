using BasicTrader.Domain.Models.Enum;
using BasicTrader.Domain.Models.RealtimePrice;
using BasicTrader.Domain.Services;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BasicTrader.FinancialModelingPrepAPI.Services
{
    public class RealtimePriceService<T> : IRealtimeData<RealtimeData> where T : class
    {
        public async Task<RealtimeData> GetRealTimePrices(IndexType indexType)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://alpha.financeapi.net/market/get-realtime-prices?symbols={indexType}"),
                    Headers =
                        {
                            { "accept", "application/json" },
                            { "X-API-KEY", "QXkz8kiyco2sQEATd98so5g0q1Fqdge13721D4Bx"},
                        },
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    RealtimeData? realtimeData = JsonConvert.DeserializeObject(body, typeof(RealtimeData)) as RealtimeData;

                    return realtimeData;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

