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
    public partial class SoporteTecnico : Form
    {
        private frmClientMain cmain;
        private frmSellerMain smain;
        private frmLogin login;

        public SoporteTecnico()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = String.Empty;
            panel2.BackColor = Color.FromArgb(50, Color.White);
            this.BackColor = Color.FromArgb(153, 153, 255);

        }

        private void lblReg_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool esseller = false;
            if (esseller == false) {
                this.Hide();
                cmain = new frmClientMain();
                cmain.Refresh();
                cmain.Show();

            }
            else {
                this.Hide();
                smain = new frmSellerMain();
                smain.Refresh();
                smain.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //formulario de enviar 
            this.Hide();
            login = new frmLogin();
            login.Refresh();
            login.Show();
        }
    }
}
