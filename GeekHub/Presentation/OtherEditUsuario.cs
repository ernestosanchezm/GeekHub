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
    public partial class OtherEditUsuario : Form
    {
        private frmLogin login;
        private frmMainView smain;

        public OtherEditUsuario()
        {
            InitializeComponent();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(153, 153, 255);
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            smain = new frmMainView();
            smain.Refresh();
            smain.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //LOGICA SAVE
            this.Hide();
            login = new frmLogin();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
