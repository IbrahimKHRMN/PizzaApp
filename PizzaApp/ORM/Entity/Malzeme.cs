using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ORM.Entity
{
    internal class Malzeme : BaseEntity
    {
        [Required]
        public string MalzemeAdi { get; set; }
        [Required]
        public int MalzemeninFiyati { get; set; }
    }
}
