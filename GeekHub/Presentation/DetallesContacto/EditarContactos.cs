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

namespace GeekHub.Presentation.DetallesContacto
{
    public partial class EditarContactos : UserControl
    {
        private string Titulo;
        private string workingDirectory = Environment.CurrentDirectory;

        private EditarContacto edc;
        public EditarContactos()
        {
            InitializeComponent();
            btn_Edit.BackColor = Color.FromArgb(153, 153, 255);
            btn_Edit.ForeColor = System.Drawing.Color.White;
            NombreContacto.ForeColor = System.Drawing.Color.FromArgb(61, 61, 61);
            btDel.BackColor = Color.FromArgb(153, 153, 255);
            btDel.ForeColor = System.Drawing.Color.White;

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            //Logica Delete
            Refresh();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            edc = new EditarContacto();
            edc.Show();
        }

        private void NombreContacto_Click(object sender, EventArgs e)
        {

        }

        private void EditarContactos_Load(object sender, EventArgs e)
        {
            Titulo = "whatsapp ";
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string image = projectDirectory + @"\Files\Logos\wsplogo.png";

            ContactImage.ImageLocation = image;
            NombreContacto.Text = Titulo;
        }
    }
}
