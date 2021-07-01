using GeekHub.Helpers;
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
    public partial class frmViewProductsDetail : Form
    {
        private PerfilUsuario perfil;
        private frmLogin login;
        private OtherEditUsuario oeu;
        private frmClientMain cmain;


        List<ListItemProductDetail> listProductsDetail;
        List<RadioButton> listFilterCategories;
        
        public frmViewProductsDetail()
        {
            InitializeComponent();       
            instanceListFilterCategory();
            this.BackColor = Color.FromArgb(153, 153, 255);
            this.label1.ForeColor = Color.FromArgb(61, 61, 61);
            this.lblFilterCategory.ForeColor = Color.FromArgb(61, 61, 61);
            this.lblFiltros.ForeColor = Color.FromArgb(61, 61, 61);

        }

        public frmViewProductsDetail(int CategoryId)
        {
            InitializeComponent();  
            instanceListFilterCategory();
            CargarProductosPorCategoria(CategoryId);
        }

        private void CargarProductosPorCategoria(int CategoryId) {
            flowLayoutPanelProduct.Controls.Clear();
            using (GeekHubWS.GeekHubWSSoapClient instWS = new GeekHubWS.GeekHubWSSoapClient())
            {
                var resultProds = instWS.ListarProductosPorCategoria(CategoryId);
                listProductsDetail = new List<ListItemProductDetail>();
                foreach (var elem in resultProds)
                {
                    Bitmap bitmap = ConvertHelper.ToBitmap(Constants.URL_BASE_FILESERVER, elem.URL_Image);
                    var objItemProd = new ListItemProductDetail
                    {
                        NameProduct = elem.NProducto,
                        PriceProduct = elem.Price.ToString(),
                        CategoryProduct = elem.NCategoria,
                        ProductoId = elem.ProductoId,
                        CategoryId = elem.CategoriaId,
                        ImageProduct = bitmap
                    };
                    flowLayoutPanelProduct.Controls.Add(objItemProd);
                    listProductsDetail.Add(objItemProd);
                }
            }
        }

        private void ActualizarListaProductos(string nombreProducto)
        {
            var FiltroItemsProd=listProductsDetail.Where(e=>e.NameProduct.Replace(" ",",").ToLower().Contains(nombreProducto.Replace(" ", ",").ToLower())).ToList();

            flowLayoutPanelProduct.Controls.Clear();

            FiltroItemsProd.ForEach(e=> {
                flowLayoutPanelProduct.Controls.Add(e);
            });           
        }

        private void instanceListFilterCategory()
        {
            using (GeekHubWS.GeekHubWSSoapClient instWS = new GeekHubWS.GeekHubWSSoapClient())
            {                
                var resultCats = instWS.ListarCategorias();
                listFilterCategories = new List<RadioButton>();
                listFilterCategories = resultCats.Select(e=>new RadioButton {
                    Tag=e.CateogoriaId.ToString(),
                    Text=e.NCategoria
                }).ToList();

                listFilterCategories.ForEach(e=> {
                    e.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
                    flowLayoutFiltrosCategory.Controls.Add(e);
                });
            }
        }



        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            CargarProductosPorCategoria(Convert.ToInt32(radioButton.Tag));          
        }

        private void frmViewProductsDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanelProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFilterCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblFiltros_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           perfil = new PerfilUsuario();
           perfil.Show();
           this.Hide();

        }

        private void bttLogOut_Click(object sender, EventArgs e)
        {
            //Logica de Logout
            login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmain = new frmClientMain();
            cmain.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ActualizarListaProductos(tbSearch.Text);
        }

        private void bttOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            oeu = new OtherEditUsuario();
            oeu.Show();
        }

        private void flowLayoutPanelOrden_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutFiltrosCategory_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
