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

        List<ListItemCategory> listCategory;
        public frmClientMain()
        {
            InitializeComponent();
        }

        private void CargarCategorias()
        {
            using (GeekHubWS.GeekHubWSSoapClient instWS=new GeekHubWS.GeekHubWSSoapClient())
            {
                listCategory = new List<ListItemCategory>();
                var resultCats = instWS.ListarCategorias();

                foreach (var elem in resultCats)
                {
                    Bitmap bitmap= ConvertHelper.ToBitmap(Constants.URL_BASE_FILESERVER+"/Categorias", "cat" + elem.CateogoriaId.ToString(),"jpg"); 
               
                    flowLayoutPanelCateg.Controls.Add(new ListItemCategory
                    {
                        NameCategory=elem.NCategoria,
                        ImageCategory=bitmap
                    });
                }
                //loop through each item
             
              
                //for (int i = 0; i < 2; i++)
                //{
                //    if (i % 2 == 0)
                //    {
                //        listCategory[i].NameCategory = "Ropa";
                //        listCategory[i].ImageCategory = new Bitmap(@"https://files.cdn.spilcloud.com/thumbs-9-0/200X120_177890_1623932027.png");
                //    }
                //    else
                //    {
                //        listCategory[i].NameCategory = "Mangas";
                //        listCategory[i].ImageCategory = Resources.manga;
                //    }
                //    flowLayoutPanelCateg.Controls.Add(listCategory[i]);

                //}
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
            this.Hide();
            login = new frmLogin();
            perfil.Show();
        }
    }
}
