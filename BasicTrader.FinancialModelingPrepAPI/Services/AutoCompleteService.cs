using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Trader.Domain.Models.AutoComplete;
using Trader.Domain.Services;
// RD7WIYDUWJN9IXFK
namespace Trader.FinancialModelingPrepAPI.Services
{
    public class AutoCompleteService<T> : IAutoCompleteService<AutoComplete> where T : class
    {
        public async Task<AutoComplete> GetAutoCompleteResults(string indexType) //MajorIndexType
        {

            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://yfapi.net/v6/finance/autocomplete?region=US&lang=en&query={indexType}"),
                    Headers =
                        {
                            { "accept", "application/json" },
                            { "X-API-KEY", "QXkz8kiyco2sQEATd98so5g0q1Fqdge13721D4Bx"},
                        },
                    //HttpResponseMessage response = await client.GetAsync("https://financialmodelingprep.com/api/v3/majors-indexes/.DJI"); //"https://financialmodelingprep.com/api/v3/nasdaq_constituent?apikey=a9bcbf3374bff8cb8e8df6274ecf3e84"
                    //string jsonResponse = await response.Content.ReadAsStringAsync();

                    //MajorIndex majorIndex = JsonConvert.DeserializeObject<MajorIndex>(jsonResponse);

                    //return majorIndex;
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    AutoComplete? autoComplete = JsonConvert.DeserializeObject(body, typeof(AutoComplete)) as AutoComplete;

                    return autoComplete;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
