using EasyDI.Test.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EasyDI.Test.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class Test : ControllerBase
    {
        private readonly IServiceA _serviceA;
        private readonly IServiceB _serviceB;
        private readonly IServiceC _serviceC;

        public Test(IServiceA serviceA, IServiceB serviceB, IServiceC serviceC)
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
                _serviceA=_serviceA.Get(),
                _serviceB=_serviceB.Get(),
                _serviceC=_serviceC.Get()
            });
        }
    }
}