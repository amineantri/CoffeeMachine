﻿using CoffeeMachine.Data.Model;
using CoffeeMachine.Data.Model.Models;
using CoffeeMachine.IRepository;

namespace CoffeeMachine.Repository
{
    public class CommandeRepository : RepositoryBase<Command>, ICommandeRepository
    {
        public CommandeRepository(CoffeeMachineContext context)
            : base(context)
        {
        }
    }
}
