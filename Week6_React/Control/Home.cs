using Microsoft.AspNetCore.Mvc;

namespace ReactAPI.Control
{
    [ApiController]
    [Route("[control]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            return new { Welcome = "Welcome Home. Good to see you!!!" };
        }
    }
}
