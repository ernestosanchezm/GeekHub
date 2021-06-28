using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub.Presentation
{
    public partial class SellerProfile : Form
    {
        private LoginSellers login;
        private SellerProfile perfil;
        private OtherEditSeller other;

        public SellerProfile()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(153, 153, 255);
            lblName.ForeColor = Color.FromArgb(61, 61, 61);
            lblApell.ForeColor = Color.FromArgb(61, 61, 61);
            label1.ForeColor = Color.FromArgb(61, 61, 61);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void bttLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new LoginSellers();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            perfil = new SellerProfile();
            perfil.Show();
        }

        private void bttOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            other = new OtherEditSeller();
            other.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void SellerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
