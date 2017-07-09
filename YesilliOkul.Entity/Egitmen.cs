using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilliOkul.Entity
{
    public class Egitmen
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        
        public virtual ICollection<Ders> Dersleri { get; set; }
        public virtual ICollection<Sinif> Siniflari { get; set; }

        public Egitmen()
        {
            //ctr yapısını kullanmazsak null reference exception hatası alırız UI'da
            Dersleri = new HashSet<Ders>();
            Siniflari = new HashSet<Sinif>();
        }
    }
}
