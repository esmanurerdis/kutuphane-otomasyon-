using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Models
{
    public class Uye
    {
        [Key]
        public int Id { get; set; }
        public string adsoyad { get; set; }
        public string tc { get; set; }
        public string yas { get; set; }
        public string cinsiyet { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string email { get; set; }
    }
}
