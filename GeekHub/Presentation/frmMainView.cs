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
    public partial class frmMainView : Form
    {
        List<ListItem> listItems;
        public frmMainView()
        {
            instanceListItems();
            InitializeComponent();
        }

        private void populateItems()
        {
            //loop through each item
            for (int i = 0; i < listItems.Count; i++)
            {
                listItems[i].NameProduct = "name";
                if (i % 2 == 0)
                {
                    listItems[i].ImageProduct = Resources.ropa;
                    listItems[i].CategoryProduct = "Category: Ropa";
                }
                else
                {
                    listItems[i].ImageProduct = Resources.comics;
                    listItems[i].CategoryProduct = "Category: Comics";
                }
                flowLayoutPanelProducts.Controls.Add(listItems[i]);

            }

        }
        private void instanceListItems()
        {
            this.listItems = new List<ListItem>();
            for (int i = 0; i < 20; i++)
            {
                this.listItems.Add(new ListItem());
            }
        }

        private void frmMainView_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
