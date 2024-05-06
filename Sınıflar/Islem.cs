using System;

namespace Kutuphane.Sınıflar
{
    public class Islem
    {
        public int islemID { get; set; }
        public int uyeID { get; set; }
        public string uyeAdi { get; set; }

        public int kitapID { get; set; }
        public string kitapAdi { get; set; }

        public string islemTarihi { get; set; }
        public string iadeTarihi { get; set; }
        public int islemDurumu { get; set; }
        public int adminID { get; set; }
    }
}
