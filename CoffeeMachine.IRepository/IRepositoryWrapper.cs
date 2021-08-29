namespace CoffeeMachine.IRepository
{
    public interface IRepositoryWrapper
    {
        IBadgeRepository Badge { get; }
        IBoissonTypeRepository BoissonType { get; }
        ICommandeRepository Commande { get; }
        IPersonRepository Person { get; }
        IPurchaseHistoryRepository PurchaseHistory { get; }
        ISugarRepository Sugar { get; }
        void Save();
    }
}
