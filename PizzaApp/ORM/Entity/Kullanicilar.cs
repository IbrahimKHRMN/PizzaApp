using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ORM.Entity
{
    public class Kullanicilar : BaseEntity
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Parola { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required] 
        public string Cinsiyet { get; set; }
        [Required] 
        public int KullaniciTipiId { get; set; }

        
    }
}
