using Kutuphane.Sınıflar;
using Kutuphane.VeriTabanı;
using Kutuphane.ZorunluDegisken;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class ProfilAyarlari : Form
    {
        VeriGetir _veriGetir = new VeriGetir(new Anahtarlar());
        Uye _uye = null;
        Admin _admin = null;
        public ProfilAyarlari()
        {
            InitializeComponent();
        }
        

       


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            VeriGuncelle veriGuncelle = new VeriGuncelle(new Anahtarlar());
            if (!Anahtarlar.Rol)
            {
                Uye uye = new Uye
                {
                    uyeID = _uye.uyeID,
                    ad = adTxt.Text,
                    soyad = soyadTxt.Text,
                    adres = adresTxt.Text,
                    telefon = telefonTxt.Text,
                    sifre = sifreTxt.Text,
                    eMail = Anahtarlar.mail
                };
                veriGuncelle.UyeGuncelle(uye);
            }
            else
            {
                Admin admin = new Admin
                {
                    adminID = _admin.adminID,
                    ad = adTxt.Text,
                    soyad = soyadTxt.Text,
                    adres = adresTxt.Text,
                    telefon = telefonTxt.Text,
                    sifre = sifreTxt.Text,
                    eMail = Anahtarlar.mail
                };
                veriGuncelle.AdminGuncelle(admin);
            }
               
        }

        private void ProfilAyarlari_Load(object sender, EventArgs e)
        {
            if (!Anahtarlar.Rol)
            {
                _uye = _veriGetir.UyeGetir(Anahtarlar.mail);

                adTxt.Text = _uye.ad;
                adresTxt.Text = _uye.adres;
                emailTxt.Text = _uye.eMail;
                soyadTxt.Text = _uye.soyad;
                sifreTxt.Text = _uye.sifre;
                telefonTxt.Text = _uye.telefon;
            }
            else
            {
                _admin = _veriGetir.AdminGetir(Anahtarlar.mail);

                adTxt.Text = _admin.ad;
                adresTxt.Text = _admin.adres;
                emailTxt.Text = _admin.eMail;
                soyadTxt.Text = _admin.soyad;
                sifreTxt.Text = _admin.sifre;
                telefonTxt.Text = _admin.telefon;
            }

        }

        private void geriBtn_Click(object sender, EventArgs e)
        {  
            if (Anahtarlar.Rol)
            {
                AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
                     adminAnasayfa.Show();
            }
            else {
                UyeAnasayfa uyeAnasayfa = new UyeAnasayfa();
                       uyeAnasayfa.Show(); }
            }
           
        }
}
