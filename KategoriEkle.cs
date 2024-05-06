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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class KategoriEkle : Form
    {
        VeriEkle _veriEkle;
        string temp = "";

        public KategoriEkle()
        {
            InitializeComponent();
        }

        public void textTemizle()
        {
            label3.Visible = true;
            kategoriEkleTxt.Clear();
            temp = "";
            araCombobox.Items.Clear();
            araCombobox.Text = "";
        }


        private void KategoriEkle_Load(object sender, EventArgs e)
        {
            VeriGetir comboHelper = new VeriGetir(new Anahtarlar());
            araCombobox.DataSource = comboHelper.KategorileriGetir();
        }

        private void kaydetBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(kategoriEkleTxt.Text))
                {
                    _veriEkle = new VeriEkle(new Anahtarlar());
                    Kategori kategori = new Kategori
                    {
                        ad = kategoriEkleTxt.Text
                    };
                    if (_veriEkle.KategoriEkle(kategori))
                    {
                        MessageBox.Show("Kayıt Eklendi", caption: "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Eklenemedi", caption: "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kategori adı girmelisiniz", caption: "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                label3.Text = "Kategori Mevcut.";
                label3.Visible = true;
            }
        }
    }
}
