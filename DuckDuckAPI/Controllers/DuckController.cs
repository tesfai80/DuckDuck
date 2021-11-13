using DuckDuckAPI.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;


namespace DuckDuckAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class DuckController : ControllerBase
    {
        private readonly ILogger<DuckController> _logger;
        private readonly IDuckDuckService _duckDuckService;
        public DuckController(ILogger<DuckController> logger , IDuckDuckService duckDuckService)
        {
           this._logger = logger;
           this._duckDuckService = duckDuckService;
        }
       
        // GET api/<DuckController>/5
        /// <summary>
        /// option to handle other format like xml
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet("{query}")]
        public async Task<IActionResult> Get(string query)
        {
            var url = BuildUrl(query);
            var response= await _duckDuckService.FetchData(url);
         
            return Ok(response);
        }
        private string BuildUrl(string query)
        {
            return $"https://api.duckduckgo.com/?q={query}&format=json";
        }
    }
}
