using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMachine.Data.Model.Models
{
    [Table("Commande")]
    public class Command
    {
        [Key]
        public Guid CommandID { get; set; }
        
        public bool HasMug { get; set; }

        public BoissonType Boisson { get; set; }

        public Sugar Sugar { get; set; }
    }
}