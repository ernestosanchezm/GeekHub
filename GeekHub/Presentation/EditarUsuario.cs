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
    public partial class EditarUsuario : Form
    {
        private frmClientMain main;

        public EditarUsuario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(153, 153, 255);
            this.ControlBox = false;
            this.Text = String.Empty;
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //Logica del save
            this.Hide();
            main = new frmClientMain();
            main.Show();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            main = new frmClientMain();
            main.Show();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
