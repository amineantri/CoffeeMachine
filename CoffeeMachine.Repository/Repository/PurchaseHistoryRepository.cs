using CoffeeMachine.Data.Model;
using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;

namespace CoffeeMachine.Repository
{
    public class PurchaseHistoryRepository : RepositoryBase<PurchaseHistory>, IPurchaseHistoryRepository
    {
        public PurchaseHistoryRepository(CoffeeMachineContext context)
            : base(context)
        {
        }
    }
}
