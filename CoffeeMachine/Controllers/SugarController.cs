using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CoffeeMachine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SugarController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly ILogger<SugarController> _logger;

        public SugarController(ILogger<SugarController> logger, IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
            _logger = logger;
        }

        //GET api/Sugar/GetTypes
        [HttpGet("GetAll")]
        public IEnumerable<Sugar> GetAllTypes()
        {
            var types = _repoWrapper.SugarRepo.FindAll();
            return types;
        }


        [HttpPost]
        public IEnumerable<Sugar> Post([FromBody] int id)
        {
            return _repoWrapper.SugarRepo.FindByCondition(x => x.ID == id);
        }
    }
}
