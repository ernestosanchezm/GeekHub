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

        public SellerProfile()
        {
            InitializeComponent();
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
    }
}
