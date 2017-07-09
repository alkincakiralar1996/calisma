using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilliOkul.Entity;

namespace YesilliOkul.DATA.Context
{
    public class YesilliOkulContext : DbContext
    {
        public YesilliOkulContext() : base("YesilliOkulContext")
        {
            //data projesini seçip önce konsola enable-migrations
            // Add-Migration kurulum
            // Update-Database
        }

        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual  DbSet<Ders> Dersler { get; set; }
        public virtual DbSet<Egitmen> Egitmenler { get; set; }
        public virtual DbSet<Sinif> Siniflar { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // pluris işlemleri için araştırma
        //    //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
