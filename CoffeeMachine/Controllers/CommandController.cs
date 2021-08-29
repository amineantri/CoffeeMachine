using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace CoffeeMachine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly ILogger<CommandController> _logger;

        public CommandController(ILogger<CommandController> logger, IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
            _logger = logger;
        }

        //GET api/Command/hasMug
        [HttpGet("hasMug")]
        public bool hasMug(Guid id)
        {
            return _repoWrapper.CommandeRepo.FindByID(x => x.CommandID == id).HasMug;
        }
    }
}
