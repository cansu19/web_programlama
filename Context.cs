using EntityLayer.Concreate;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Kategoriler> Kategorilers { get; set; }
        public DbSet<Kullanicilar> Kullanicilars{ get; set; }
        public DbSet<Tarifler> Tariflers { get; set; }
        public DbSet<Yemekler> Yemeklers{ get; set; }
    }
}
