using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Kategoriler
    {
        [Key]
        public int Kategoriid { get; set; }
        [StringLength(50)]
        public string KategoriAd { get; set; }
        public bool KategoriStatus { get; set; }

        public ICollection<Yemekler> Yemeklers { get; set; }
    }
}
