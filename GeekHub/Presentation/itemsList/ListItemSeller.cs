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
    public partial class ListItemSeller : UserControl
    {
        public ListItemSeller(string nameSeller, string typeShop, string description, string typeDocument, string document, string imageLocation)
        {
            InitializeComponent();
            lblNameSeller.BackColor = Color.FromArgb(153, 153, 255);
            this._nameSeller = nameSeller;
            this._typeDocument = typeDocument;
            this._document = document;
            this._typeShop = typeShop;
            this._description = description;
            this.imageSeller.ImageLocation = imageLocation;
        }
        public ListItemSeller()
        {
            InitializeComponent();
            lblNameSeller.BackColor = Color.FromArgb(153, 153, 255);
        }

        public int UserSellerId { get; set; }

        #region Properties
        private string _nameSeller;
        private string _typeShop;
        private string _description;
        private string _typeDocument;
        private string _document;
        private Image _imageSeller;

        [Category("Seller props")]
        public string NameSeller
        {
            get { return _nameSeller; }
            set { _nameSeller = value; lblNameSeller.Text = value; }
        }

        [Category("Seller props")]
        public string TypeShop
        {
            get { return _typeShop; }
            set { _typeShop= value; lblTypeShop.Text = value; }
        }
        [Category("Seller props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; lblDescription.Text = value; }
        }
        [Category("Seller props")]
        public string TypeDocument
        {
            get { return _typeDocument; }
            set { _typeDocument = value; lblTypeDocument.Text = value; }
        }
        [Category("Seller props")]
        public string Document
        {
            get { return _document; }
            set { _document = value; lblDocument.Text = value; }
        }

        [Category("Seller props")]
        public Image ImageSeller
        {
            get { return _imageSeller; }
            set { _imageSeller = value; imageSeller.Image = value; }
        }
        #endregion

    }
}
