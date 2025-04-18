using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto.Services;
using System.Runtime.CompilerServices;

namespace PrimeiroProjeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILifecycloService _service;
        private readonly Lifecycle2Service _service2;
        public WeatherForecastController(ILifecycloService service , Lifecycle2Service  service2)
        {
            
            _service = service; 
            _service2 = service2;
        }

        [HttpGet]
        public IActionResult Get() { 
             List<DateTime> result = new List<DateTime>()
             {
                 _service.DataAtual(),
                 _service2.DataAtual()
             };

            return Ok(result);
        }
    }
}
