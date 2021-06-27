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
    public partial class PerfilSerllerUserView : Form
    {
        private DetallesContacto.DetallesContacto dc;
        private frmClientMain cmain;
        private frmLogin login;
        private OtherEditUsuario oeu;
        private PerfilUsuario perfil;

        public PerfilSerllerUserView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dc = new DetallesContacto.DetallesContacto();
            dc.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmain = new frmClientMain();
            cmain.Show();
        }

        private void bttOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            oeu = new OtherEditUsuario();
            oeu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            perfil = new PerfilUsuario();
            perfil.Show();
        }
    }
}
