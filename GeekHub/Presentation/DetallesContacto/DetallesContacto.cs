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
    public partial class Detail_Control : UserControl
    {
        
        public Detail_Control(string titulo, string image, string link)
        {
            InitializeComponent();
            this._title = titulo;
            this._Imagen = image;
            this._Link = link;
            ContactImage.ImageLocation = image;
            NombreContacto.Text = _title;



            ContactImage.Refresh();
            
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            var process =  System.Diagnostics.Process.Start(MyLink);
        }

        private void Detail_Control_Load(object sender, EventArgs e)
        {
            Btn_Contact.BackColor = Color.FromArgb(153, 153, 255);
            Btn_Contact.ForeColor = System.Drawing.Color.White;
            NombreContacto.ForeColor = System.Drawing.Color.FromArgb(61, 61,61);
        }

        #region Propiedades
        private string _title;
        private string _Link;
        private string _Imagen;

        [Category("CustomProperties")]
        public string MyTitle
        {
            get { return _title; }
            set { _title = value; NombreContacto.Text = _title; this.Refresh(); }
        }

        [Category("CustomProperties")]
        public string MyLink
        {
            get { return _Link; }
            set { _Link = value; this.Refresh(); }
        }

        [Category("CustomProperties")]
        public string MyImage
        {
            get { return _Imagen; }
            set { _Imagen = value; ContactImage.ImageLocation = _Imagen; }
        }

        #endregion

        private void NombreContacto_Click(object sender, EventArgs e)
        {

        }

        private void ContactImage_Click(object sender, EventArgs e)
        {

        }
    }
}
