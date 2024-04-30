using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Models
{
    public class Kitap
    {
        [Key]
        public int Id { get; set; }
        public string barkodno { get; set; }
        public string kitapadi { get; set; }
        public string yazari { get; set; }
        public string yayinevi { get; set; }
        public string sayfasayisi { get; set; }
        public string turu { get; set; }
        public int stoksayisi { get; set; }
        public string rafno { get; set; }
        public string aciklama { get; set; }
        public DateTime kayittarihi { get; set; }
    }
}
