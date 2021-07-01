using GeekHub;
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
    public partial class fmrRegister : Form
    {
        frmLogin lgin;

        public fmrRegister()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = String.Empty;
            panel2.BackColor = Color.FromArgb(50, Color.White);

        }


        private void fmrRegister_Load(object sender, EventArgs e)
        {
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {

        }

        private void btcnl_Click(object sender, EventArgs e)
        {
            lgin = new frmLogin();
            lgin.Show();
            this.Hide();

        }

        private void lbldni_Click(object sender, EventArgs e)
        {

        }

        private void btAcc_Click(object sender, EventArgs e)
        {

        }
    }
}
