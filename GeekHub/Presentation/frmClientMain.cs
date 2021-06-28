using GeekHub.Helpers;
using GeekHub.Presentation.itemsList;
using GeekHub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub.Presentation
{
    public partial class frmClientMain : Form
    {
        private PerfilUsuario perfil;
        private frmLogin login;
        private OtherEditUsuario oe;
        private frmClientMain cmain;

        List<ListItemCategory> listCategory;

        public frmClientMain()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(153, 153, 255);
            this.label1= = Color.FromArgb(61, 61, 61);
        }

        private void CargarCategorias()
        {
            using (GeekHubWS.GeekHubWSSoapClient instWS=new GeekHubWS.GeekHubWSSoapClient())
            {
                listCategory = new List<ListItemCategory>();
                var resultCats = instWS.ListarCategorias();

                foreach (var elem in resultCats)
                {
                    Bitmap bitmap= ConvertHelper.ToBitmap(Constants.URL_BASE_FILESERVER+"Categorias", "cat" + elem.CateogoriaId.ToString(),".jpg"); 
               
                    flowLayoutPanelCateg.Controls.Add(new ListItemCategory("","")
                    {
                        NameCategory=elem.NCategoria,
                        ImageCategory=bitmap,
                        CategoryId=elem.CateogoriaId
                    });
                }                
            }       
        }

        private void frmClientMain_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            perfil = new PerfilUsuario();
            perfil.Show();
        }

        private void bttLogOut_Click(object sender, EventArgs e)
        {
            //Logica Cerrar Sesion
            this.Hide();
            login = new frmLogin();
            perfil.Show();
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
