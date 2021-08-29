using CoffeeMachine.Data.Model;
using CoffeeMachine.IRepository;

namespace CoffeeMachine.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private CoffeeMachineContext _repoContext;

        private IBadgeRepository _badge;
        
        private IBoissonTypeRepository _boissonType;

        private ICommandeRepository _commande;

        private IPersonRepository _person;

        private IPurchaseHistoryRepository _purchaseHistory;

        private ISugarRepository _sugar;
        
        public IBadgeRepository Badge
        {
            get
            {
                if (_badge == null)
                {
                    _badge = new BadgeRepository(_repoContext);
                }
                return _badge;
            }
        }

        public IBoissonTypeRepository BoissonType
        {
            get
            {
                if (_boissonType == null)
                {
                    _boissonType = new BoissonTypeRepository(_repoContext);
                }
                return _boissonType;
            }
        }

        public ICommandeRepository Commande
        {
            get
            {
                if (_commande == null)
                {
                    _commande = new CommandeRepository(_repoContext);
                }
                return _commande;
            }
        }

        public IPersonRepository Person
        {
            get
            {
                if (_person == null)
                {
                    _person = new PersonRepository(_repoContext);
                }
                return _person;
            }
        }

        public IPurchaseHistoryRepository PurchaseHistory
        {
            get
            {
                if (_purchaseHistory == null)
                {
                    _purchaseHistory = new PurchaseHistoryRepository(_repoContext);
                }
                return _purchaseHistory;
            }
        }

        public ISugarRepository Sugar
        {
            get
            {
                if (_sugar == null)
                {
                    _sugar = new SugarRepository(_repoContext);
                }
                return _sugar;
            }
        }

        public RepositoryWrapper(CoffeeMachineContext context)
        {
            _repoContext = context;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
