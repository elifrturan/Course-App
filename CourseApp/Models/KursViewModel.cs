using EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class KursViewModel
    {
        public int KursID { get; set; }
        public string? Baslik { get; set; }
        public int? OgretmenID { get; set; }
        
    }
}
