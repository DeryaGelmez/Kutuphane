using Kutuphane.Sınıflar;
using Kutuphane.VeriTabanı;
using Kutuphane.ZorunluDegisken;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Kutuphane
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        // Giriş yapan kişinin kaydının olup olmadığının kontrolü, kayıtlıysa sisteme giriş yapması değilse gerekli hata mesajlarının gösterilmesi

        public static AnaEkran obj = (AnaEkran)Application.OpenForms["AnaEkran"];
        string secim;

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void girisBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (chkAdmin.Checked)
                    secim = "admin";
                else
                    secim = "uye";

                VeriKontrol veriKontrol = new VeriKontrol(new Anahtarlar());

                Giris giris = new Giris();
                giris.eMail = kullaniciAdi.Text;
                giris.sifre = sifre.Text;

                bool girisYapildimi = veriKontrol.GirisYap(giris, secim);


                if (girisYapildimi)
                {
                    if (secim == "admin")
                    {
                        AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
                        VeriGetir.girisYapID = giris.girisYapID; //Giris yapan kişinin ID'sini formlarla paylaşma
                        VeriGetir.secim = secim;  //Giris yapan kişinin şifresini formlarla paylaşma

                        adminAnasayfa.Show();
                        this.Visible = false;
                        Anahtarlar.mail = kullaniciAdi.Text;
                        Anahtarlar.Rol = true;

                    }
                    else
                    {
                        UyeAnasayfa uyeAnasayfa = new UyeAnasayfa();
                        VeriGetir.girisYapID = giris.girisYapID; //girisyapanın ıd sini formlarla paylaşma
                        VeriGetir.secim = secim;
                        AnaEkran.girisKapat = false;
                        uyeAnasayfa.email = kullaniciAdi.Text;
                        uyeAnasayfa.Show();
                        this.Visible = false;
                        Anahtarlar.mail = kullaniciAdi.Text;
                        Anahtarlar.Rol = false;
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgilerinizi kontrol ediniz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı hatası. Bilgilerinizi kontrol edin.");
            }
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
        }

        private void kullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            kullaniciAdi.ForeColor = Color.Black;
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {
            sifre.ForeColor = Color.Black;
        }

        private void gosterBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(gosterBtn.Checked)
            {
                sifre.UseSystemPasswordChar = false;
            }
            else
            {
                sifre.UseSystemPasswordChar = true;
            }
        }
    }
}
