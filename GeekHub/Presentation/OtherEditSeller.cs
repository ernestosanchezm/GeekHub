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
    
    public partial class OtherEditSeller : Form
    {
        private LoginSellers login;
        private frmSellerMain smain;
       

        public OtherEditSeller()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = String.Empty;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            bool condition = true;
            this.Close();
            //si se modifico correo y/o password
            if (condition)
            {
                login = new LoginSellers();
                login.Show();
            }
            else
            {
                smain = new frmSellerMain();
                smain.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            smain = new frmSellerMain();
            smain.Show();
        }

        private void OtherEditSeller_Load(object sender, EventArgs e)
        {

        }
    }
}
