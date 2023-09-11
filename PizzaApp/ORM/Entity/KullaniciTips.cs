using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ORM.Entity
{
    public abstract class KullaniciTips
    {
        public int ID { get; set; }
        public int KullaniciTipi { get; set; }

        List<Kullanicilar> Kullanicilars = new List<Kullanicilar>();
    }
}
