using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kurs
    {
        [Key]
        public int KursID { get; set; }
        public string? Baslik { get; set; }
        public int? OgretmenID { get; set; }
        public Ogretmen Ogretmen { get; set; }
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }
}
