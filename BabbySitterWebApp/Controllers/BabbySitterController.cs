using Microsoft.AspNetCore.Mvc;
using BabbySitter.Models;

namespace YourNamespace
{
    [ApiController]
    [Route("babbysitter")]
    public class BabySitterController : ControllerBase
    {
        [HttpGet("all")]
        public IEnumerable<Babysitter> Get()
        {
            
            var babysitters = new List<Babysitter>
            {
                new Babysitter("Babysitter 1", 25, "Experienced"),
                new Babysitter("Babysitter 2", 30, "Certified"),
                // Add more babysitters here...
            };
            return babysitters;
        }
    }

    public record Babysitter(string Name, int Age, string Qualification);
}