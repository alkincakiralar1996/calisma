using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilliOkul.DATA.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity:class 
    {
        // public,vs --> access modifire denir interface içinde yazılmaz

        void Ekle(TEntity nesne);
        void Guncelle(TEntity nesne);
        void Sil(TEntity nesne);
        TEntity IdyeGoreGetir(int id);
        List<TEntity> OgrencileriGetir();
    }
}
