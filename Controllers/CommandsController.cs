using System.Collections.Generic;
using CommanderAPI.Data;
using CommanderAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommanderAPI.Controllers
{

    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repo;

        public CommandsController(ICommanderRepo repository) => _repo = repository;


        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repo.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repo.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}