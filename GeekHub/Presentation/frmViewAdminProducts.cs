using GeekHub.Presentation.itemsList;
using GeekHub.Properties;
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
    public partial class frmViewAdminProducts : Form
    {
        private PerfilUsuario perfil;
        private frmLogin login;
        private OtherEditUsuario oe;
        private frmClientMain cmain;

        List<ProductDetailAdmin> listItemsProducts;
        List<ListItemSeller> listItemsSellers;
        public frmViewAdminProducts()
        {
            InitializeComponent();
        }

        private void frmViewAdminProducts_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {
            listItemsProducts = new List<ProductDetailAdmin>();
            listItemsSellers = new List<ListItemSeller>();
            for(int i = 0; i < 20; i++)
            {
                listItemsProducts.Add(new ProductDetailAdmin());
                listItemsSellers.Add(new ListItemSeller());
            }
            //loop through each item
            for (int i = 0; i < listItemsProducts.Count; i++)
            {
                listItemsProducts[i].NameProduct = "name product";
                listItemsProducts[i].ImageProduct = Resources.user;
                listItemsProducts[i].CategoryProduct = "Category: Ropa";
                flowLayoutPanelProducts.Controls.Add(listItemsProducts[i]);

            }
            for (int i = 0; i < listItemsSellers.Count; i++)
            {
                listItemsSellers[i].NameSeller = "name seller";
                listItemsSellers[i].ImageSeller = Resources.user;
                flowLayoutPanelSellers.Controls.Add(listItemsSellers[i]);

            }

        }
    }
}
