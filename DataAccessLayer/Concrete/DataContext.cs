using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<KursKayit> KursKayitlari { get; set; }
        public DbSet<Ogretmen> Ogretmenler{ get; set; }
    }
}
