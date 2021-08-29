using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMachine.Data.Model.Models
{
    [Table("BoissonType")]
    public class BoissonType
    {
        [Key]
        public Guid TypeID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, ErrorMessage = "")]
        public string BoissonName { get; set; }
    }
}
