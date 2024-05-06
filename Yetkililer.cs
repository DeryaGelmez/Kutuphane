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
    public partial class Yetkililer : Form
    {
        public Yetkililer()
        {
            InitializeComponent();
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();
        }
    }
}
