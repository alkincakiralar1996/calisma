using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilliOkul.Entity
{
    public class Ders
    {
        // [Key] yazmanın bir anlamı yok
        // prop ID & ClassAdiID olursa kendi primary key tanımlıyor
        public int ID { get; set; }

        public string Ad { get; set; }

        public int HaftalikDersSaati { get; set; }

        public virtual  ICollection<Ogrenci> Ogrencileri { get; set; }
        public virtual  ICollection<Egitmen> Egitmenleri { get; set; }
        public virtual  ICollection<Sinif> Siniflari { get; set; }

        public Ders()
        {
            //ctr yapısını kullanmazsak null reference exception hatası alırız UI'da
            Egitmenleri = new HashSet<Egitmen>();
            Siniflari = new HashSet<Sinif>();
        }
    }
}
