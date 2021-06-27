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
                    
                    //WebClient client = new WebClient();
                    //Stream stream = client.OpenRead(imageUrl);
                    Bitmap bitmap= ConvertHelper.ToBitmap("https://localhost:44383/Fileserver/Categorias", "cat" + elem.CateogoriaId.ToString(),"jpg"); 
                    //bitmap = new Bitmap(stream);

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
    }
}
