using GeekHub.Presentation.DetallesContacto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub.Presentation
{
    public partial class FrmEditContact : Form
    {
        frmSellerMain smain;
        public FrmEditContact()
        {
            InitializeComponent();
            Panel.Visible = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = String.Empty;
            CargarMetodos();


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            smain = new frmSellerMain();
            smain.Show();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CargarMetodos()
        {

            int CantidadDeContactos = 3;

            EditarContactos[] Detalles = new EditarContactos[CantidadDeContactos];

            for (int i = 0; i < CantidadDeContactos; i++)
            {
                Detalles[i] = new EditarContactos();

                Panel.Controls.Add(Detalles[i]);
            }

            Panel.Refresh();
        }

        private void FrmEditContact_Load(object sender, EventArgs e)
        {
            Panel.BackColor = Color.FromArgb(255, 239, 156);

        }

        private void Contact_Methods_Click(object sender, EventArgs e)
        {

        }
    }
}
