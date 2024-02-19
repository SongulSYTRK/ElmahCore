using ElmahCore;
using ElmahCoreTestApi.Models.EF.InputAllUsersContext;
using Microsoft.AspNetCore.Mvc;

namespace ElmahCoreTestApi.Controllers
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
        private readonly object _webAPICoreTutorialContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            try
            {

                int zero = 0;

                var t = 10 / zero;

                //InputAllUser g = _webAPICoreTutorialContext.InputAllUsers
                //    .Where(y => y.Id == 1).First();

                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)] + ":V4"
                   
                })
                .ToArray();
            }
            catch (Exception ex)
            {
                ElmahExtensions.RaiseError(ex);

                return Enumerable.Empty<WeatherForecast>().ToArray();
            }
        }
    }
}