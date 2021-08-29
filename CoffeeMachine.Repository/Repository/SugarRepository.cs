using CoffeeMachine.Data.Model;
using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;

namespace CoffeeMachine.Repository
{
    public class SugarRepository : RepositoryBase<Sugar>, ISugarRepository
    {
        public SugarRepository(CoffeeMachineContext context)
            : base(context)
        {
        }
    }
}
