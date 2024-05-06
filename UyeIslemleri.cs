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
    public partial class UyeIslemleri : Form
    {
        public UyeIslemleri()
        {
            InitializeComponent();
        }

        private bool BoslukKontrol()
        {
            bool output = true;

            if (adTxt.Text == "" || soyadTxt.Text == "" || emailTxt.Text == "" || telefonTxt.Text == "" || adresTxt.Text == "")
            {
                output = false;
            }

            return output;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoslukKontrol())
                {
                    Uye uye = new Uye();

                    uye.ad = adTxt.Text;
                    uye.soyad = soyadTxt.Text;
                    uye.eMail = emailTxt.Text;
                    uye.sifre = textBox4.Text;
                    uye.telefon = telefonTxt.Text;
                    uye.adres = adresTxt.Text;

                    VeriEkle uyeEkle = new VeriEkle(new Anahtarlar());

                    if (uyeEkle.UyeEkle(uye))
                    {
                        MessageBox.Show("Üye başarılı bir şekilde eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Üye eklerken hata meydana geldi.");
                    }
                }
                else
                {
                    MessageBox.Show("Boş bırakmayın..");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası. Bilgileri kontrol edin.");
                Console.WriteLine(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Anahtarlar anahtarlar = new Anahtarlar();
            VeriGetir veriGetir = new VeriGetir(anahtarlar);
            dataGridView1.DataSource = veriGetir.UyeAra(uyeAraTxt.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            adTxt.Text = selectedRow.Cells["ad"].Value.ToString();
            soyadTxt.Text = selectedRow.Cells["soyad"].Value.ToString();
            emailTxt.Text = selectedRow.Cells["eMail"].Value.ToString();
            adresTxt.Text = selectedRow.Cells["adres"].Value.ToString();
            telefonTxt.Text = selectedRow.Cells["telefon"].Value.ToString();
            label7.Text = selectedRow.Cells["uyeID"].Value.ToString();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoslukKontrol())
                {
                    Uye uye = new Uye();
                    uye.ad = adTxt.Text;
                    uye.uyeID = Convert.ToInt32(label7.Text);
                    uye.soyad = soyadTxt.Text;
                    uye.eMail = emailTxt.Text;
                    uye.adres = adresTxt.Text;
                    uye.telefon = telefonTxt.Text;
                    uye.sifre = textBox4.Text;
                    VeriGuncelle veriGuncelle = new VeriGuncelle(new Anahtarlar());

                    if (veriGuncelle.UyeGuncelle(uye))
                    {
                        MessageBox.Show("Uye başarılı bir şekilde güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Uye güncellenirken hata meydana geldi.");
                    }
                }
                else
                {
                    MessageBox.Show("Boş bırakmayın..");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası. Bilgileri kontrol edin.");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(emailTxt.Text))
                {
                    Uye uye = new Uye();
                    uye.eMail = emailTxt.Text;
                    uye.uyeID = Convert.ToInt32(label7.Text);
                    VeriSil veriSil = new VeriSil(new Anahtarlar());
                    if (veriSil.UyeSil(uye))
                    {
                        MessageBox.Show("Silme işlemi başarılı.");
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi sırasında hata meydana geldi");
                    }
                }
                else
                {
                    MessageBox.Show("Boş bırakmayın..");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kitap kullanıcı tarafında işlem görüyor.");
            }
        }
    }
}
