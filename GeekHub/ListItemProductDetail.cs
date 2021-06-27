using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub
{
    public partial class ListItemProductDetail : UserControl
    {
        public ListItemProductDetail()
        {
            InitializeComponent();
        }
        #region Properties
        private string _nameProduct;
        private string _categoryProduct;
        private string _detailProduct;
        private string _priceProduct;
        private string _descuentoProduct;
        private Image _imageProduct;

        [Category("Product props")]
        public string NameProduct
        {
            get { return _nameProduct; }
            set { _nameProduct = value; lblNameProduct.Text = value; }
        }
        [Category("Product props")]
        public string DetailProduct
        {
            get { return _detailProduct; }
            set { _detailProduct = value; lblDescription.Text = value; }
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
        public string DescuentoProducto
        {
            get { return _descuentoProduct; }
            set { _descuentoProduct = value; lblDescuento.Text = value; }
        }

        [Category("Product props")]
        public Image ImageProduct
        {
            get { return _imageProduct; }
            set { _imageProduct = value; pictureBox1.Image = value; }
        }
        #endregion
    }
}
