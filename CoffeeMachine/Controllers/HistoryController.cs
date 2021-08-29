using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CoffeeMachine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly ILogger<HistoryController> _logger;

        public HistoryController(ILogger<HistoryController> logger, IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
            _logger = logger;
        }

        //GET api/PurchaseHistory/GetLastPurchase
        [HttpGet("GetLastPurchase")]
        public PurchaseHistory GetLAst(string name)
        {
            return _repoWrapper.PurchaseHistoryRepo.FindLast(x => x.Person.PersonName == name);
        }
    }
}
