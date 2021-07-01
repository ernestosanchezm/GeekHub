using GeekHub.Helpers;
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
        private int SellerId;
        private frmSellerMain smain;
        private SoporteTecnico Stec;

        public frmSellerMain()
        {
            InitializeComponent();
            cargarMetodos();
            this.BackColor = Color.FromArgb(153, 153, 255);
            button1.BackColor = Color.FromArgb(50, Color.White);

        }

        public frmSellerMain(int _SellerId)
        {
            InitializeComponent();
            SellerId = _SellerId;
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

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            string image = projectDirectory + @"\GeekHub_WS\Fileserver\Productos\p_02_01.jpg";
            int CantidadDeContactos = 3;
            
            SellerMain[] Detalles = new SellerMain[CantidadDeContactos];

            GeekHubWS.GeekHubWSSoapClient instWS = new GeekHubWS.GeekHubWSSoapClient();
            //var resLogin=instWS.loginFindByEmailAndPassword("tommy.s@gmail.com", "1234");
            //var resLogin = instWS.loginFindByEmailAndPassword("solange.s@gmail.com", "1234"); 
            var resLogin = instWS.loginFindByEmailAndPassword("tommy.s@gmail.com", "1234");
            var prodsSeller = instWS.ListarProductosPorVendedor(SellerId);

            foreach (var elem in prodsSeller) {
                Bitmap bitmap = ConvertHelper.ToBitmap(Constants.URL_BASE_FILESERVER + elem.URL_Image);
                Panel01.Controls.Add(new SellerMain { 
                    MyTitle=elem.NProducto,
                    MyPrice=elem.Price.ToString(),
                    MyDate=elem.FRegistro.ToString(),
                    MyImage= Constants.URL_BASE_FILESERVER + elem.URL_Image
                });
            }
           
            for (int i = 0; i < CantidadDeContactos; i++)
            {
                Detalles[i] = new SellerMain(titulo, precio,date,image, "1");
                              
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

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            smain = new frmSellerMain();
            smain.Refresh();
            smain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stec = new SoporteTecnico();
            Stec.Show();
        }
    }
}
