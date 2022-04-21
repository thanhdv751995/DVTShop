using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDVT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly IRepositoryManager _repository;
        private readonly ILogger<WeatherForecastController> _loggerr;
        private ILoggerManager _logger;

        public WeatherForecastController(
            ILogger<WeatherForecastController> loggerr,
            IRepositoryManager repository,
            ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info message from our values controller.");
            _logger.LogDebug("Here is debug message from our values controller.");
            _logger.LogWarn("Here is warn message from our values controller.");
            _logger.LogError("Here is an error message from our values controller.");
            return new string[] { "value1", "value2" };
        }
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    _repository.Company.AnyMethodFromCompanyRepository();
        //    _repository.Employee.AnyMethodFromEmployeeRepository();
        //    return new string[] { "value1", "value2" };
        //}


    }
}
