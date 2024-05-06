using Kutuphane.Sınıflar.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Sınıflar
{
    public class Kitap
    {
        public int kitapID { get; set; }
        public string ISBN { get; set; }
        public string ad { get; set; }
        public string yazar { get; set; }
        public string baskiYili { get; set; }
        public string yayinEvi { get; set; }
        public string sayfaSayisi { get; set; }
        public byte[] fotograf { get; set; }
        public string aciklama { get; set; }
        public int kategoriID { get; set; }
        public Enum_KitapDurumu kitapDurumu { get; set; }
        public int islemSayisi { get; set; } //En çok okunanları tutabilmek için
        public int adminID { get; set; }
    }
}
