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
    public partial class frmViewCategory : Form
    {
        List<ListItemCategory> listCategory;
        public frmViewCategory()
        {
            InitializeComponent();
            this.listCategory = new List<ListItemCategory>();
            for (int i = 0; i < 20; i++)
            {
                this.listCategory.Add(new ListItemCategory());
            }
        }

        private void populateItems()
        {
            //loop through each item
            for (int i = 0; i < listCategory.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listCategory[i].NameCategory = "Ropa";
                    listCategory[i].ImageCategory = Resources.ropa;
                }
                else
                {
                    listCategory[i].NameCategory = "Mangas";
                    listCategory[i].ImageCategory = Resources.manga;
                }
                flowLayoutPanelCateg.Controls.Add(listCategory[i]);

            }

        }

        private void frmViewCategory_Load(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
