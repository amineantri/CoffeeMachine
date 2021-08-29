using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMachine.Data.Model.Models
{
    [Table("Badge")]
    public class Badge
    {
        public Guid badgeID { get; set; }

        public PurchaseHistory history { get; set; }
    }
}