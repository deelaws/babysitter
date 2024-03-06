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
                new Babysitter("Niyomi Khalid", 33, "Experienced"),
                new Babysitter("Ayra Shahid", 3, "Certified"),
                // Add more babysitters here...
            };
            return babysitters;
        }
    }

    public record Babysitter(string Name, int Age, string Qualification);
}