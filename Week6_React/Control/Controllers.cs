using Microsoft.AspNetCore.Mvc;

namespace ReactAPI.Control
{
    [ApiController]
    [Route("[controller]")]
    public class AboutController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            return new {
                Title = "Basic React API Page",
                Description = "This API supports a simple Single Page Application using React as frontend + C# as backend."
            };
        }
    }
}
