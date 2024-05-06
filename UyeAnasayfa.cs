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
    public partial class UyeAnasayfa : Form
    {
        public  string email = "";
        public UyeAnasayfa()
        {
            InitializeComponent();
        }

        private void btnEmanetIslem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ProfilAyarlari profilAyarlari = new ProfilAyarlari();
            profilAyarlari.Visible = true;
        }

        private void UyeAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnKitapIslem_Click(object sender, EventArgs e)
        {

        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaEkran anaEkran = new AnaEkran();
            anaEkran.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
