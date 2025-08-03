using Microsoft.AspNetCore.Mvc;
using Backend.Models;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CricketPlayers> Get()
        {
            var players = new CricketPlayers
            {
                T20players = new List<string> { "Virat Kohli", "Rohit Sharma", "MS Dhoni" },
                RanjiTrophyPlayers = new List<string> { "Wasim Jaffer", "Cheteshwar Pujara", "Karun Nair" }
            };
            return Ok(players);
        }
    }
}
