using System.Collections.Generic; // Support IEnumerable
using Microsoft.AspNetCore.Mvc; 
using CommandAPI.Data;
using CommandAPI.Models;


namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase // Inherit from controller base
    {
        private readonly ICommandAPIRepo _repository ;
        public CommandsController(ICommandAPIRepo repository)
        {
            _repository = repository;
        }
        // Before DI
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> get()
        // {
        //     return new string[] {"this","is","hard", "coded"};
        // }

        // DI 
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id) 
        {
            var commandItem = _repository.GetCommandById(id);
            if(commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);

        }
    }
}