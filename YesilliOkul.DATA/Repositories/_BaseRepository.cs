using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilliOkul.DATA.Context;
using YesilliOkul.Entity;

namespace YesilliOkul.DATA.Repositories
{
    public class BaseRepository<TEntity> where TEntity:class 
    {
        // ekle guncelle sil idye göregetir , hepsini etir

        YesilliOkulContext context = new YesilliOkulContext();

        public void Ekle(TEntity nesne)
        {
            context.Set<TEntity>().Add(nesne);
            context.SaveChanges();
        }

        public void Guncelle(TEntity nesne)
        {
            context.Entry(nesne).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Sil(TEntity nesne)
        {
            context.Set<TEntity>().Remove(nesne);
            context.SaveChanges();
        }

        public TEntity IdyeGoreOgrenciGetir(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> HepsiniGetir()
        {
            return context.Set<TEntity>().ToList();
        }
    }
}
