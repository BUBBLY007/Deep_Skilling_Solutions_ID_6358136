using Microsoft.AspNetCore.Mvc;

namespace ReactAPI.Control
{
    [ApiController]
    [Route("[controller]")]
    public class ThemeController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            return new { Theme = "light", AccentColor = "#cc5500" };
        }
    }
}
