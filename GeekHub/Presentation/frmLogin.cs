using GeekHub.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeekHub.Presentation.DetallesContacto;

namespace GeekHub.Presentation
{
    using System.Drawing;



    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(50, Color.White);

        }
        private fmrRegister registro;
        private LoginSellers sellers;

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            GeekHubWS.GeekHubWSSoapClient instWS = new GeekHubWS.GeekHubWSSoapClient();
            var resLogin=instWS.loginFindByEmailAndPassword("solange.s@gmail.com", "1234");

            if (resLogin != null)
            {
                switch (resLogin.RoleId)
                {
                    case 1:
                        var frmAdm = new frmAdminMain();
                        frmAdm.Show();
                        break;
                    case 2:
                        var frmSeller = new frmSellerMain();
                        frmSeller.Show();
                        break;
                    case 3:
                        var frmClient = new frmClientMain();
                        frmClient.Show();
                        break;
                }
                this.Hide();
            }         
            else
            {
                MessageBox.Show("Credenciales erradas", "Error Login", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void txPsw_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Contact_Methods_Click(object sender, EventArgs e)
        {

        }

        private void Contact_Methods_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            registro = new fmrRegister();
            registro.Show();
            this.Hide();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUsers_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vendedores_Click(object sender, EventArgs e)
        {
            sellers = new LoginSellers();
            sellers.Show();
            this.Hide();

        }
    }
}
