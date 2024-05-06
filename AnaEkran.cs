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
    public partial class AnaEkran : Form
    {
        VeriGetir kitapYardimci = new VeriGetir(new Anahtarlar());
        public AnaEkran()
        {
            InitializeComponent();
        }


        static public bool girisKapat = true;


        private void AnaEkran_Load(object sender, EventArgs e)
        {
            //KategorileriGetir metodundan dönen kategoriler listesinin ögelerini combobox'a ekleme
            kategoriBox.DataSource = kitapYardimci.KategorileriGetir();
            //Combobox'ta gösterilecek ögeler, kategori nesnesinin ad özelliğinden alınacak ve seçilebilecek.
            kategoriBox.DisplayMember = "ad";
            //Satırın herhangi bir yerine tıklanarak tüm satırın seçilebilmesi işlemi
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void araBtn_Click(object sender, EventArgs e)
        {
            //KitapAra metodunu çağırma
            dataGridView1.DataSource = kitapYardimci.KitapAra(araTxt.Text, ((Kategori)kategoriBox.SelectedItem).ad);
            dataGridView1.Visible = true;
            icerikPanel.Visible = false;
            panel1.Visible = false;
         

        }

        private void kategoriBox_Click_1(object sender, EventArgs e)
        {
            kategoriBox.Items.Clear();

        }
        private void kategoriBox_SelectedValueChanged_1(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;
            icerikPanel.Visible = false;
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            GirisEkrani girisGit = new GirisEkrani();
            girisGit.ShowDialog();
        }


        private void kategoriBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void girisBtn_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Visible = true;
        }

        private void araTxt_TextChanged_1(object sender, EventArgs e)
        {
            araTxt.ForeColor = Color.Black;
        }
    }
}
