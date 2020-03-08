using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CentralBankIntegrationLibrary;
using InterfaceBrokerIntegrationLibrary;
using DTO;

namespace BrokerService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : Controller
    {
      /*  private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }*/

       [Route("Get")]
        public IEnumerable<Course> Get(BankTypes provider)
        {
            IBroker c = BrokerFactory.CreateBroker(provider);
             return c.A();
            
        }
       [Route("GetMax")]
       public int Sosi(int number1,int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            return number2;
        }
    }
}
