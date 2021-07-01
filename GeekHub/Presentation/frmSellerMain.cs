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
    public partial class frmSellerMain : Form
    {
        private OtherEditSeller other;
        private LoginSellers login;
        private SellerProfile profile;


        public frmSellerMain()
        {
            InitializeComponent();
            cargarMetodos();
            this.BackColor = Color.FromArgb(153, 153, 255);

        }


        private void cargarMetodos()
        {
            string titulo, precio, date;
            titulo= "nombre";

            precio = "21.1";

            date = "11/12/2000";
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            string image = projectDirectory + @"\Files\Logos\wsplogo.png";
            int CantidadDeContactos = 3;
            

            SellerMain[] Detalles = new SellerMain[CantidadDeContactos];
           
            for (int i = 0; i < CantidadDeContactos; i++)
            {
                Detalles[i] = new SellerMain(titulo, precio,date,image, "1");
                Panel01.Controls.Add(Detalles[i]);               
            }

        }

        private void PanelItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSellerMain_Load(object sender, EventArgs e)
        {
            Panel01.ForeColor = Color.FromArgb(255, 239, 156);
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            cargarMetodos();

        }

        private void bttLogOut_Click(object sender, EventArgs e)
        {
            //Logica Cerrar Sesion
            this.Hide();
            login = new LoginSellers();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile = new SellerProfile();
            profile.Show();
        }

        private void bttOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            other = new OtherEditSeller();
            other.Show();
        }
    }
}
