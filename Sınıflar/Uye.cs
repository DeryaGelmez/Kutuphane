﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Sınıflar
{
    public class Uye
    {
        public int uyeID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string eMail { get; set; }
        public string sifre { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public int adminID { get; set; }
        public bool uyelikDurumu { get; set; }
        public string cezaTarihi { get; set; }
    }
}
