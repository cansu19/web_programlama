using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class KategorilerManager
    {
        GenericRepository<Kategoriler> repo = new GenericRepository<Kategoriler>();
        public List<Kategoriler> GetAllBL()
        {
            return repo.List();
        }
        public void KategoriAddBL(Kategoriler p)
        {
            if (p.KategoriAd == "" || p.KategoriAd.Length <= 3 || p.KategoriAd.Length >= 50)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
                
            
        }
    }
}
