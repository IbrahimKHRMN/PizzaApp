using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ORM.Entity
{
    public abstract class BaseEntity
    {
        [Required]
        public int ID { get; set; }
    }
}
