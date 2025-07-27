using Microsoft.AspNetCore.Mvc;
using ReactAPI.Models;

namespace ReactAPI.Control
{
    [ApiController]
    [Route("[controller]")]
    public class Scorecont : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Score> Get()
        {
            return new List<Score>
            {
                new Score { Student = "Kaushiki", Points = 95 },
                new Score { Student = "Susmita", Points = 100 }
            };
        }
    }
}
