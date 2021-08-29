using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;
using CoffeeMachine.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CoffeeMachine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoissonController : ControllerBase
    {
        private IRepositoryWrapper<BoissonType> _repoWrapper;
        private readonly ILogger<BoissonController> _logger;

        public BoissonController(IRepositoryWrapper<BoissonType> repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        //GET api/Boisson/GetTypes
        [HttpGet("GetAll")]
        public IEnumerable<BoissonType> GetAllTypes()
        {
            return _repoWrapper.FindAll();
        }

        //GET api/Boisson/GetByID
        [HttpGet("GetByID")]
        public BoissonType GetByID(int id)
        {
            return _repoWrapper.FindByID(x => x.TypeID == id);
        }

        [HttpPost]
        public IEnumerable<BoissonType> Post([FromBody] string boisson)
        {
            return _repoWrapper.FindByCondition(x => x.BoissonName ==boisson);
        }


    }
}
