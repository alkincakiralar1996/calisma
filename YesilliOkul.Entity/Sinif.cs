using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilliOkul.Entity
{
    public class Sinif
    {
        public int ID { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<Ogrenci> Ogrencileri { get; set; }
        public virtual ICollection<Ders> Dersleri { get; set; }
        public  virtual  ICollection<Egitmen> Egitmenleri { get; set; }

        public Sinif()
        {
            //ctr yapısını kullanmazsak null reference exception hatası alırız UI'da
            Ogrencileri = new List<Ogrenci>();
            Dersleri = new HashSet<Ders>();
            Egitmenleri = new HashSet<Egitmen>();

        }
    }
}
