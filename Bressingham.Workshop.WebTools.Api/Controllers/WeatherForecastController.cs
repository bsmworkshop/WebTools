using Bressingham.Workshop.WebTools.Logic;
using Microsoft.AspNetCore.Mvc;

namespace Bressingham.Workshop.WebTools.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWebToolsLogic _logic;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWebToolsLogic logic)
        {
            _logger = logger;
            _logic = logic;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = _logic.GetNumberOfMaterials(),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
