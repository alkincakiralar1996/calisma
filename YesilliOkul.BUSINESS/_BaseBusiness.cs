using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilliOkul.DATA.Repositories;
using YesilliOkul.Entity;

namespace YesilliOkul.BUSINESS
{
    public class _BaseBusiness<Tentity> where Tentity:class 
    {
        BaseRepository<Tentity> repo = new BaseRepository<Tentity>();

        public string Ekle(Tentity nesne)
        {
            try
            {
                repo.Ekle(nesne);

            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

        public string Guncelle(Tentity nesne)
        {
            try
            {
                repo.Guncelle(nesne);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

        public string Sil(Tentity nesne)
        {
            try
            {
                repo.Sil(nesne);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }

        public Tentity IdyeGoreGetir(int id)
        {
            return repo.IdyeGoreOgrenciGetir(id);
        }

        public List<Tentity> OgrencileriGetir()
        {
            return repo.HepsiniGetir();
        }
    }
}
