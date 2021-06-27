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

namespace GeekHub
{
    public partial class ViewCategory : Form
    {
        List<ListItemCategory> listCategory;
        public ViewCategory()
        {
            InitializeComponent();
            this.listCategory = new List<ListItemCategory>();
            for (int i = 0; i < 20; i++)
            {
                this.listCategory.Add(new ListItemCategory());
            }
            InitializeComponent();
        }

        private void ViewCategory_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {
            //loop through each item
            for (int i = 0; i < listCategory.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listCategory[i].NameCategory = "Ropa";
                    listCategory[i].ImageCategory = Resources.ropa1;
                }
                else
                {
                    listCategory[i].NameCategory = "Mangas";
                    listCategory[i].ImageCategory = Resources.manga1;
                }
                flowLayoutPanelCateg.Controls.Add(listCategory[i]);

            }

        }
    }
}
