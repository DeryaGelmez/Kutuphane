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
    public partial class EmanetIslemleri : Form

    {
        public EmanetIslemleri()
        {
            InitializeComponent();
        }
        VeriGetir _veriGetir = new VeriGetir(new Anahtarlar());
        private void temizleBtn_Click(object sender, EventArgs e)
        {

        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();
        }

        private void kitapAraTxt_TextChanged(object sender, EventArgs e)
        {
            kitapAraTxt.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = _veriGetir.KitapAra(kitapAraTxt.Text, "Herhangi");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uyeAraBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _veriGetir.UyeAra(uyeAraTxt.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            uyeIDTxt.Text = selectedRow.Cells["uyeID"].Value.ToString();
        }

        private void EmanetIslemleri_Load(object sender, EventArgs e)
        {
            if (Anahtarlar.Rol)
            {
                yetkiliIDTxt.Text = VeriGetir.girisYapID;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
            kitapIDTxt.Text = selectedRow.Cells["kitapID"].Value.ToString();
        }

        private void verBtn_Click(object sender, EventArgs e)
        {
            VeriGetir veriGetir = new VeriGetir(new Anahtarlar());
            if (veriGetir.KitapDurumSorgula(Convert.ToInt32(kitapIDTxt.Text)))
            {
                if (veriGetir.IslemSorgulama(new Islem { uyeID = Convert.ToInt32(uyeIDTxt.Text), kitapID = Convert.ToInt32(kitapIDTxt.Text) }))
                {
                    VeriGuncelle veriEkle = new VeriGuncelle(new Anahtarlar());
                    Islem islem = new Islem
                    {
                        uyeID = Convert.ToInt32(uyeIDTxt.Text),
                        kitapID = Convert.ToInt32(kitapIDTxt.Text),
                        islemTarihi = DateTime.Now.ToString(),
                        iadeTarihi = DateTime.Now.ToString(),
                        islemDurumu = 1,
                        adminID = Convert.ToInt32(VeriGetir.girisYapID),
                    };
                    if (veriEkle.IslemGuncelle(islem))
                    {
                        MessageBox.Show("İşlem başarılı");
                    }
                    else
                    {
                        MessageBox.Show("İşlem sırasında hata meydana geldi.");
                    }
                }
                else
                {
                    VeriEkle veriEkle = new VeriEkle(new Anahtarlar());
                    Islem islem = new Islem
                    {
                        uyeID = Convert.ToInt32(uyeIDTxt.Text),
                        kitapID = Convert.ToInt32(kitapIDTxt.Text),
                        islemTarihi = DateTime.Now.ToString(),
                        iadeTarihi = dateTimePicker2.Value.ToString(),
                        islemDurumu = 1,
                        adminID = Convert.ToInt32(VeriGetir.girisYapID),
                    };
                    if (veriEkle.KitapVer(islem))
                    {
                        MessageBox.Show("İşlem başarılı");
                    }
                    else
                    {
                        MessageBox.Show("İşlem sırasında hata meydana geldi.");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Kitap mevcut değil");
            }
        }

        private void alBtn_Click(object sender, EventArgs e)
        {
            VeriGuncelle veriEkle = new VeriGuncelle(new Anahtarlar());
            Islem islem = new Islem
            {
                islemID = Convert.ToInt32(teslimIdTxt.Text),
                uyeID = Convert.ToInt32(uyeIDTxt.Text),
                kitapID = Convert.ToInt32(kitapIDTxt.Text),
                islemTarihi = DateTime.Now.ToString(),
                iadeTarihi = DateTime.Now.ToString(),
                islemDurumu = 0,
                adminID = Convert.ToInt32(VeriGetir.girisYapID),
            };
            if (veriEkle.IslemGuncelle(islem))
            {
                MessageBox.Show("İşlem başarılı");
            }
            else
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi.");
            }
        }

        private void islemAraBtn_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = _veriGetir.IslemGetir(islemAraTxt.Text);

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
            teslimIdTxt.Text = selectedRow.Cells["islemID"].Value.ToString();
            uyeIDTxt.Text = selectedRow.Cells["uyeID"].Value.ToString();
            kitapIDTxt.Text= selectedRow.Cells["kitapID"].Value.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
