using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMachine.Data.Model.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public Guid PersonID { get; set; }

        public string PersonName { get; set; }

        public Badge Badge { get; set; }
    }
}
