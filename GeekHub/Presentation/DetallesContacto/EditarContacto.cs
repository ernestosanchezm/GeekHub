using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub.Presentation.DetallesContacto
{
    public partial class EditarContacto : Form
    {
        public EditarContacto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(153, 153, 255);
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            Refresh();
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
