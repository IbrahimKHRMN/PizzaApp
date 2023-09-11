using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ORM.Entity
{
    internal class Kullanicilar : BaseEntity
    {
        public string Email { get; set; }
        public string Parola { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public int KullaniciTipiId { get; set; }

        
    }
}
