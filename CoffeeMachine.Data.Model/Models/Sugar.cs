using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMachine.Data.Model.Models
{
    [Table("Sugar")]
    public class Sugar
    {
        [Key]
        public Guid ID { get; set; }


        [Required(ErrorMessage = "Quantity is required")]
        [Range(0, 4)]
        public int Quantity { get; set; }
    }
}
