using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeekHub.Presentation.DetallesContacto;
using GeekHub.Presentation.itemsList;

namespace GeekHub.Presentation
{
    public partial class DetalleProducto : Form
    {
        private OtherEditUsuario oeu;
        private DetallesContacto.DetallesContacto dc;
        private frmLogin login;
        private frmClientMain cmain;
        private ListItemProductDetail product;

        public DetalleProducto()
        {
            InitializeComponent();
        }

        private void bttOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            oeu = new OtherEditUsuario();
            oeu.Show();
        }

        private void lbS_Click(object sender, EventArgs e)
        {


        }

        private void bt_contactos_Click(object sender, EventArgs e)
        {
            dc = new DetallesContacto.DetallesContacto();
            dc.Show();
        }

        private void bttLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new frmLogin(); 
            login.Show();
        }

        private void bt_SelProf_Click(object sender, EventArgs e)
        {

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmain = new frmClientMain();
            cmain.Show();
        }

        private void DetalleProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
