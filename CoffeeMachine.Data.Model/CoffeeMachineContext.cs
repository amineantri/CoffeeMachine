using CoffeeMachine.Data.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace CoffeeMachine.Data.Model
{
    public class CoffeeMachineContext : DbContext
    {
        public CoffeeMachineContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Command> Commandes { get; set; }
        public DbSet<PurchaseHistory> PurchaseHistories { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Sugar> Sugars { get; set; }
        public DbSet<BoissonType> BoissonTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    //        modelBuilder
    //            .Entity<Sugar>(
    //                eb =>
    //                {
    //                    eb.HasNoKey();
    //                });
    //        modelBuilder.Entity<Command>()
    //.HasOne(a => a.Sugar)
    //.WithOne(b => b.Quantity)
    //.HasForeignKey<Sugar>(b => b.);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CodeFirstUpdateConnectionString);
        }


        private static string _codeFirstUpdateConnectionString;

        private static string CodeFirstUpdateConnectionString
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_codeFirstUpdateConnectionString))
                {
                    _codeFirstUpdateConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                }
                return _codeFirstUpdateConnectionString;
            }
        }
    }
}
