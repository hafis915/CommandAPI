using System.Collections.Generic; // Support IEnumerable
using Microsoft.AspNetCore.Mvc; 
namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase // Inherit from controller base
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> get()
        {
            return new string[] {"this","is","hard", "coded"};
        }
    }
}