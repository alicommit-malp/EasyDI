using EasyDI.Test.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EasyDI.Test.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TestController : ControllerBase
    {
        private readonly IServiceA _serviceA;
        private readonly IServiceB _serviceB;
        private readonly IServiceC _serviceC;

        public TestController(IServiceA serviceA, IServiceB serviceB, IServiceC serviceC)
        {
            _serviceA = serviceA;
            _serviceB = serviceB;
            _serviceC = serviceC;
        }

        // GET
        public IActionResult Get()
        {
            return Ok(new
            {
                _serviceA=_serviceA.Do(),
                _serviceB=_serviceB.Do(),
                _serviceC=_serviceC.Do()
            });
        }
    }
}