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
    public partial class LoginSellers : Form
    {
        private frmLogin login;

        public LoginSellers()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(50, Color.White);

        }

        private void btn_Vendedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new frmLogin();
            login.Show();
        }

        private void LoginSellers_Load(object sender, EventArgs e)
        {

        }
    }
}
