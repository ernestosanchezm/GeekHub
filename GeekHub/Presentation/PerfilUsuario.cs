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
    public partial class PerfilUsuario : Form
    {
        private EditarUsuario eu;
        private OtherEditUsuario oe;
        private frmClientMain cmain;

        public PerfilUsuario()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(153, 153, 255);
            this.lblName.ForeColor = Color.FromArgb(61, 61, 61);
            this.lblApell.ForeColor = Color.FromArgb(61, 61, 61);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditDatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            eu = new EditarUsuario();
            eu.Show();
        }

        private void PerfilUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnEditFoto_Click(object sender, EventArgs e)
        {
            //logica del edit de la foto

        }

        private void bttOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            oe = new OtherEditUsuario();
            oe.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmain = new frmClientMain();
            cmain.Show();
        }
    }
}
