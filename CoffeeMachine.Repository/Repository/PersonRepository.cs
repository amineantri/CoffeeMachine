using CoffeeMachine.Data.Model;
using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;

namespace CoffeeMachine.Repository
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(CoffeeMachineContext context)
            : base(context)
        {
        }
    }
}
