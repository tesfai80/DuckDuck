using DuckDuckAPI.Interfaces;
using DuckDuckAPI.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DuckDuckAPI.Services
{
    public class DuckDuckService : IDuckDuckService
    {
        private readonly IHttpClientFactory _http;
        public DuckDuckService(IHttpClientFactory clientFactory)
        {
            _http = clientFactory;
        }
        public async Task<DuckModel> FetchData(string ApiUrl)
        {
            using var client = _http.CreateClient();
            using var httpResponse = await client.GetAsync(ApiUrl);
            httpResponse.EnsureSuccessStatusCode();
            if (httpResponse.IsSuccessStatusCode)
            {
                    var json = await httpResponse.Content.ReadAsStringAsync();
                    try
                    {
                        return JsonConvert.DeserializeObject<DuckModel>(json);
                    }
                    catch (JsonSerializationException)
                    {
                        throw;
                    }
              
            }
            return null;
        }
    }
}
