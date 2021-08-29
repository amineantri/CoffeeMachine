using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoffeeMachine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger, IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
            _logger = logger;
        }

        //GET api/person/getPerson
        [HttpGet("GetPerson")]

        public IEnumerable<Person> GetPersons()
        {
            var persons = _repoWrapper.PersonRepo.FindAll();
            return persons;
        }
    }
}
