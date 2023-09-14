using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ORM.Entity
{
    public class Pizzalar : BaseEntity
    {
        [Required]
        public string PizzaAdi { get; set; }
        [Required]
        public double PizzaFiyati { get; set; }
        [Required]
        public string Icindekiler { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
