using CoffeeMachine.Data.Model;
using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;

namespace CoffeeMachine.Repository
{
    public class BadgeRepository : RepositoryBase<Badge>, IBadgeRepository
    {
        public BadgeRepository(CoffeeMachineContext context)
            : base(context)
        {
        }
    }
}
