using Kutuphane.Sınıflar;
using Kutuphane.VeriTabanı;
using Kutuphane.ZorunluDegisken;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class KitapIslemleri : Form
    {
        VeriGetir _veriGetir = new VeriGetir(new Anahtarlar());
        string sorgu = "t1.ISBN,t1.ad as Ad,t1.yazar as Yazar, t3.kategoriAdi as Kategori, t1.baskiYili as Yıl, t1.yayinEvi as Yayın, t1.sayfaSayisi as Sayfa, t1.fotograf as Foto, t1.aciklama as Detay";
        string tablo = "kitap t1  INNER JOIN kitap_kategori t2 ON t1.kitapID = t2.kitapID INNER JOIN kategori t3 ON t2.kategoriID = t3.kategoriID";

        string isbn, ad, yazar, baskiYili, yayinEvi, sayfaSayisi, aciklama, kategori;

        MemoryStream memoryStream = new MemoryStream();

        public KitapIslemleri()
        {
            InitializeComponent();
        }

        private bool BoslukKontrol()
        {
            bool output = true;

            if (txtISBN.Text == "" || adTxt.Text == "" || yazarTxt.Text == "" || kategoriCombobox.Text == "" || baskiYiliTxt.Text == "" || yayinEviTxt.Text == "" || sayfaSayisiTxt.Text == "" || aciklamaTxt.Text == "")
            {
                output = false;
            }

            return output;
        }
        public void textTemizle()
        {
            txtISBN.Text = "";
            adTxt.Text = "";
            yazarTxt.Text = "";
            sayfaSayisiTxt.Text = "";
            yayinEviTxt.Text = "";
            kategoriCombobox.Text = "";
            baskiYiliTxt.Text = "";
            aciklamaTxt.Text = "";

        }
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (BoslukKontrol())
                {
                    Kitap kitap = new Kitap();
                    kitap.ISBN = txtISBN.Text;
                    kitap.ad = adTxt.Text;
                    kitap.yazar = yazarTxt.Text;
                    kitap.yayinEvi = yayinEviTxt.Text;
                    kitap.kategoriID = ((Kategori)kategoriCombobox.SelectedItem).kategoriID;
                    kitap.sayfaSayisi = sayfaSayisiTxt.Text;
                    kitap.baskiYili = baskiYiliTxt.Text;
                    kitap.aciklama = aciklamaTxt.Text;
                    kitap.adminID = int.Parse(VeriGetir.girisYapID);

                    VeriEkle veriEkle = new VeriEkle(new Anahtarlar());

                    if (veriEkle.KitapEkle(kitap))
                    {
                        MessageBox.Show("Kitap başarılı bir şekilde eklendi.");
                    }
                }
                else
                {
                    MessageBox.Show("Boş bırakmayın..");
                }

                isbn = ""; ad = ""; yazar = ""; baskiYili = ""; yayinEvi = ""; sayfaSayisi = ""; aciklama = ""; kategori = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası. Bilgileri kontrol edin.");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _veriGetir.KitapAra(kitapAraTxt.Text, "Herhangi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            txtISBN.Text = selectedRow.Cells["ISBN"].Value.ToString();
            adTxt.Text = selectedRow.Cells["ad"].Value.ToString();
            yazarTxt.Text = selectedRow.Cells["yazar"].Value.ToString();
            foreach (Kategori kategori in kategoriCombobox.Items)
            {
                if (kategori.kategoriID == Convert.ToInt32(selectedRow.Cells["kategoriID"].Value.ToString()))
                {
                    kategoriCombobox.SelectedItem = kategori;
                    kategoriCombobox.DisplayMember = "ad";

                    break;
                }
            }
            baskiYiliTxt.Text = selectedRow.Cells["baskiYili"].Value.ToString();
            yayinEviTxt.Text = selectedRow.Cells["yayinEvi"].Value.ToString();
            sayfaSayisiTxt.Text = selectedRow.Cells["sayfaSayisi"].Value.ToString();
        }

        private void KitapIslemleri_Load_1(object sender, EventArgs e)
        {
            kategoriCombobox.DataSource = _veriGetir.KategorileriGetir();
            kategoriCombobox.DisplayMember = "ad";
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();
        }

        private void kategoriCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtISBN.Text))
                {
                    Kitap kitap = new Kitap();
                    kitap.ISBN = txtISBN.Text;
                    if (kitap == null)
                    {
                        Console.WriteLine("Kitap bilgileri boş.");
                        return;
                    }
                    VeriSil kitapYardimci = new VeriSil(new Anahtarlar());
                    if (kitapYardimci.KitapSil(kitap))
                    {
                        MessageBox.Show("Silme işlemi başarılı.");
                    }
                    txtISBN.ReadOnly = false;
                    txtISBN.BackColor = Color.White;
                    textTemizle();
                }
                else
                {
                    MessageBox.Show("Boş bırakmayın..");
                }
                isbn = ""; ad = ""; yazar = ""; baskiYili = ""; yayinEvi = ""; sayfaSayisi = ""; aciklama = ""; ; kategori = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Kitap kullanıcı tarafında işlem görüyor.");
            }
        }

        private void kitapAraTxt_MouseClick(object sender, MouseEventArgs e)
        {
            kitapAraTxt.Text = string.Empty;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoslukKontrol())
                {
                    Kitap kitap = new Kitap();
                    kitap.ISBN = txtISBN.Text;
                    kitap.ad = adTxt.Text;
                    kitap.yazar = yazarTxt.Text;
                    kitap.yayinEvi = yayinEviTxt.Text;
                    kitap.kategoriID = ((Kategori)kategoriCombobox.SelectedItem).kategoriID;
                    kitap.sayfaSayisi = sayfaSayisiTxt.Text;
                    kitap.baskiYili = baskiYiliTxt.Text;
                    kitap.aciklama = aciklamaTxt.Text;
                    kitap.adminID = int.Parse(VeriGetir.girisYapID);

                    VeriGuncelle veriGuncelle = new VeriGuncelle(new Anahtarlar());

                    if (veriGuncelle.KitapGuncelle(kitap))
                    {
                        MessageBox.Show("Kitap başarılı bir şekilde güncellendi.");
                    }
                }
                else
                {
                    MessageBox.Show("Boş bırakmayın..");
                }

                isbn = ""; ad = ""; yazar = ""; baskiYili = ""; yayinEvi = ""; sayfaSayisi = ""; aciklama = ""; kategori = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası. Bilgileri kontrol edin.");
                Console.WriteLine(ex.Message);
            }
        }

        private void kategoriEkleBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void kitapAraTxt_TextChanged(object sender, EventArgs e)
        {
            kitapAraTxt.ForeColor = Color.Black;
        }

        private void KitapIslemleri_Load(object sender, EventArgs e)
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



        }


        //kategorileri combobox'a eklemek için
        private void kategoriCombobox_Click(object sender, EventArgs e)
        {
            kategoriCombobox.Items.Clear();

        }






        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
