using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class KursKayit
    {
        [Key]
        public int KayitID { get; set; }
        public int OgrenciID { get; set; }
        public int KursID { get; set; }
        public DateTime KayitTarihi { get; set; }
        public Kurs Kurs {  get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
