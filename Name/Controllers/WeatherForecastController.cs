using Microsoft.AspNetCore.Mvc;

namespace Name.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class MyNameController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "json notation";
        }
    }
}