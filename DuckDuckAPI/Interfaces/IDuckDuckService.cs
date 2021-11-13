using DuckDuckAPI.Model;
using System.Threading.Tasks;

namespace DuckDuckAPI.Interfaces
{
    public interface IDuckDuckService
    {
       public Task<DuckModel> FetchData(string query);
    }
}
