using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilliOkul.Entity
{
    [Table("Students")] // database tablosundaki ismi bu şekilde değiştirebiliriz,attrlar araştırılmalı
    public class Ogrenci
    {
        //[Key] // böyle otomatik identity verir
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)] // otomatik artmasını kaldırdı 
        public int TC { get; set; }

        [MaxLength(50)]
        public string Ad { get; set; }

        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public virtual  ICollection<Ders> Dersleri { get; set; }
        public virtual Sinif Siniflari { get; set; } // bi öğrencinin bir sınıfı olacağı için list yapmanın anlamı yk

        public Ogrenci()
        {
            //ctr yapısını kullanmazsak null reference exception hatası alırız UI'da
            Dersleri = new HashSet<Ders>();
        }
    }
}
