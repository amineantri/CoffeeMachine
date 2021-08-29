using CoffeeMachine.Data.Model;
using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;

namespace CoffeeMachine.Repository
{
    public class BoissonTypeRepository : RepositoryBase<BoissonType>, IBoissonTypeRepository
    {
        public BoissonTypeRepository(CoffeeMachineContext context)
            : base(context)
        {
        }
    }
}
