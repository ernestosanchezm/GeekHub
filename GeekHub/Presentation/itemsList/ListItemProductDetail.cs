using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub.Presentation.itemsList
{
    public partial class ListItemProductDetail : UserControl
    {
        public ListItemProductDetail(string nameProduct, string categoryProduct,string priceProduct, string imageLocation)
        {           
            InitializeComponent();
            lblNameProduct.BackColor = Color.FromArgb(153, 153, 255);
            this._categoryProduct = categoryProduct;
            this._nameProduct = nameProduct;
            this._priceProduct = priceProduct;
            productImage.ImageLocation = imageLocation;

        }
        public ListItemProductDetail()
        {
            InitializeComponent();
            lblNameProduct.BackColor = Color.FromArgb(153, 153, 255);
        }
        public int ProductoId { get; set; }
        public int CategoryId { get; set; }

        #region Properties
        private string _nameProduct;
        private string _categoryProduct;
        private string _priceProduct;
        private Image _imageProduct;

        [Category("Product props")]
        public string NameProduct
        {
            get { return _nameProduct; }
            set { _nameProduct = value; lblNameProduct.Text = value; }
        }

        [Category("Product props")]
        public string PriceProduct
        {
            get { return _priceProduct; }
            set { _priceProduct = value; lblPrice.Text = value; }
        }
        [Category("Product props")]
        public string CategoryProduct
        {
            get { return _categoryProduct; }
            set { _categoryProduct = value; lblCategory.Text = value; }
        }


        [Category("Product props")]
        public Image ImageProduct
        {
            get { return _imageProduct; }
            set { _imageProduct = value; productImage.Image = value; }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
