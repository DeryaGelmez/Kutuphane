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
    public partial class AdminAnasayfa : Form
    {
        public AdminAnasayfa()
        {
            InitializeComponent();
        }


        private void AbrirFormPanel(object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }

        private void btnKitapIslem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new KitapIslemleri());
        }
        private void btnUyeIslem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new UyeIslemleri());

        }
        private void btnEmanetIslem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new EmanetIslemleri());

        }
        private void btnYetkiliIslem_Click(object sender, EventArgs e)
        {

        }
        private void cikisYap_Click(object sender, EventArgs e)
        {


            this.Close();
            GirisEkrani.obj.Visible = true;


        }
        private void profilBtn_Click(object sender, EventArgs e)
        {
            ProfilAyarlari profil = new ProfilAyarlari();
            profil.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUyeIslem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            UyeIslemleri uyeIslemleri = new UyeIslemleri();
            uyeIslemleri.Visible = true;
        }

        private void AdminAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnKitapIslem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            KitapIslemleri kitapIslemleri = new KitapIslemleri();
            kitapIslemleri.Visible = true;
        }

        private void profilBtn_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            ProfilAyarlari profilAyarlari = new ProfilAyarlari();
            profilAyarlari.Visible = true;
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
        }

        private void btnEmanetIslem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
           EmanetIslemleri emanetIslemleri = new EmanetIslemleri();
            emanetIslemleri.Visible = true;
        }

        private void btnYetkiliIslem_Click_1(object sender, EventArgs e)
        {
        }

        private void AdminAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
