using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon.Common
{
    public class MusteriOda
    {
        public Musteri Musteri { get; set; }
        public Oda KalinacakOda { get; set; }
        public int ToplamBorc { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
    }
}
