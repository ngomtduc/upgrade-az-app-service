using Microsoft.AspNetCore.Mvc;

namespace UpgradeAppService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello. This API runs on Net 6.";
        }
    }
}
