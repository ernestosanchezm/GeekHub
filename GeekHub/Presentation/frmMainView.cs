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
using GeekHub.Presentation;

namespace GeekHub.Presentation
{
    public partial class frmMainView : Form
    {
        private PerfilUsuario perfil;
        private frmLogin login;
        private OtherEditUsuario oe;
        private frmClientMain cmain;

        List<ListItem> listItems;
        public frmMainView()
        {
            instanceListItems();
            InitializeComponent();
            this.BackColor = Color.FromArgb(153, 153, 255);
            label1.ForeColor = Color.FromArgb(61, 61, 61);
            Refresh();
        }

        private void populateItems()
        {
            ////loop through each item
            //for (int i = 0; i < listItems.Count; i++)
            //{
            //    listItems[i].NameProduct = "name";
            //    if (i % 2 == 0)
            //    {
            //        listItems[i].ImageProduct = Resources.ropa;
            //        listItems[i].CategoryProduct = "Category: Ropa";
            //    }
            //    else
            //    {
            //        listItems[i].ImageProduct = Resources.comics;
            //        listItems[i].CategoryProduct = "Category: Comics";
            //    }
            //    flowLayoutPanelProducts.Controls.Add(listItems[i]);

            //}

        }
        private void instanceListItems()
        {
            this.listItems = new List<ListItem>();
            for (int i = 0; i < 20; i++)
            {
                this.listItems.Add(new ListItem("","",""));
            }
        }

        private void frmMainView_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void bttOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            oe = new OtherEditUsuario();
            oe.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            perfil = new PerfilUsuario();
            perfil.Show();
        }

        private void flowLayoutPanelProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttLogOut_Click(object sender, EventArgs e)
        {
            //Logica Cerrar Sesion
            this.Hide();
            login = new frmLogin();
            login.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmain = new frmClientMain();
            cmain.Show();
        }
    }
}
