using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMachine.Data.Model.Models
{
    [Table("PurchaseHistory")]
    public class PurchaseHistory
    {
        [Key]
        public Guid HistoryID { get; set; }

        [Required(ErrorMessage = "Command date is required")]
        public DateTime CommandDate { get; set; }

        public BoissonType Boisson { get; set; }

        public Sugar Sugar { get; set; }
    }
}