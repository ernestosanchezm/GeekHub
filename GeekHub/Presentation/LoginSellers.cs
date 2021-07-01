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

        private void btLogin_Click(object sender, EventArgs e)
        {
            GeekHubWS.GeekHubWSSoapClient instWS = new GeekHubWS.GeekHubWSSoapClient();
            //var resLogin = instWS.loginFindByEmailAndPassword("tommy.s@gmail.com", "1234");
            //var resLogin = instWS.loginFindByEmailAndPassword("solange.s@gmail.com", "1234");
            var resLogin = instWS.loginFindByEmailAndPassword("cielo.s@gmail.com", "1234"); 

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
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales erradas", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
