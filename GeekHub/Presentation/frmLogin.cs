using GeekHub.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

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
    }
}
