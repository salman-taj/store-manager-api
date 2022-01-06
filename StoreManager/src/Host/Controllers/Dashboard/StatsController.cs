using Microsoft.AspNetCore.Mvc;
using StoreManager.Application.Dashboard;

namespace StoreManager.Host.Controllers.Dashboard
{
    public class StatsController : BaseController
    {
        private readonly IStatsService _service;

        public StatsController(IStatsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var stats = await _service.GetDataAsync();
            return Ok(stats);
        }
    }
}