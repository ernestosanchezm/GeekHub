using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub.Presentation.DetallesContacto
{
    public partial class SellerMain : UserControl
    {
        public SellerMain() { }
        public SellerMain(string np,string price, string date, string image, string id)
        {
                        InitializeComponent();

            _title = np;
            _price = price;                     
            _date = date;
            _Imagen = image;
            this.id = id;
            MyTitle = _title;
            MyPrice = _price;
            MyImage = _Imagen;
            MyDate = _date;
            MyTitle = _title;
            MyDate = date;
            MyPrice = price;
            ContactImage.ImageLocation = image;

            ContactImage.Refresh();

        }

        private string id;

        #region Propiedades
        private string _title;
        private string _price;
        private string _date;
        private string _LinkEditar;
        private string _LinkEliminar;
        private string _Imagen;

        [Category("CustomProperties")]
        public string MyTitle
        {
            get { return _title; }
            set { _title = value; }
        }
        [Category("CustomProperties")]
        public string MyPrice
        {
            get { return _price; }
            set { _price = value; }
        }
        [Category("CustomProperties")]
        public string MyDate
        {
            get { return _date; }
            set { _date = value; }
        }
        [Category("CustomProperties")]
        public string EditarLink
        {
            get { return _LinkEditar; }
            set { _LinkEditar = value;  }
        }
        [Category("CustomProperties")]
        public string EliminarLink
        {
            get { return _LinkEliminar; }
            set { _LinkEliminar = value; }
        }
        [Category("CustomProperties")]
        public string MyImage
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }

        #endregion

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //logica del eliminar

        }

        private void SellerMain_Load(object sender, EventArgs e)
        {
            btn_eliminar.BackColor = Color.FromArgb(153, 153, 255);
            btn_eliminar.ForeColor = System.Drawing.Color.White;
            lblprecio.ForeColor = System.Drawing.Color.FromArgb(61, 61, 61);
            lbldt.ForeColor = System.Drawing.Color.FromArgb(61, 61, 61);
            NombreProducto.ForeColor = System.Drawing.Color.FromArgb(61, 61, 61);
        }

        private void NombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void ContactImage_Click(object sender, EventArgs e)
        {

        }
    }
}
