using Microsoft.AspNetCore.Mvc;
using ReactAPI.Models;
using System.Collections.Generic;

namespace ReactAPI.Control
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PostModel> Get()
        {
            return new List<PostModel>
            {
                new PostModel { Id = 1, Title = "First Post" },
                new PostModel { Id = 2, Title = "Second Post" }
            };
        }

        [HttpGet("error")]
        public IActionResult ThrowError()
        {
            try
            {
                throw new Exception("Error occurred");
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }
    }
}
