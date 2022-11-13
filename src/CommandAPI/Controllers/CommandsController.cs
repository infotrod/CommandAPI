// This file was created by Rustem and all manually typed.
using System.Collections.Generic;
using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;

        public CommandsController(ICommandAPIRepo reposirory)
        {
            _repository = reposirory;
        }

        // Add the following code
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        // Add next code for pulling in a single resource. Handle null appropriatly.
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommand(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);
        }

    }
}