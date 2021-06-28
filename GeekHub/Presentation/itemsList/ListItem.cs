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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            panel1.BackColor= Color.FromArgb(153, 153, 255);
            lblNameProduct.BackColor = Color.FromArgb(153, 153, 255);

            InitializeComponent();
        }
        #region Properties
        private string _nameProduct;
        private string _categoryProduct;
        private Image _imageProduct;

        [Category("Product props")]
        public string NameProduct
        {
            get { return _nameProduct; }
            set { _nameProduct = value; lblNameProduct.Text = value; }
        }
        [Category("Product props")]
        public string CategoryProduct
        {
            get { return _categoryProduct; }
            set { _categoryProduct = value; lblCategoryProduct.Text = value; }
        }

        [Category("Product props")]
        public Image ImageProduct
        {
            get { return _imageProduct; }
            set { _imageProduct = value; pictureBox1.Image = value; }
        }
        #endregion

        private void ListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
