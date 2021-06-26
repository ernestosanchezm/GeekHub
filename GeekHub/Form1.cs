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
    public partial class Form1 : Form
    {
        List<ListItem> listItems;
        public Form1()
        {
            this.listItems = new List<ListItem>();
            for (int i = 0; i < 20; i++)
            {
                this.listItems.Add(new ListItem());
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            populateItems();
        }

        private void populateItems()
        {
            ListItem[] items = new ListItem[20];
            //loop through each item
            for (int i = 0; i < listItems.Count; i++)
            {
                listItems[i].NameProduct = "name";
                if(i%2 == 0)
                {
                    listItems[i].ImageProduct = Resources.ropa1;
                    listItems[i].CategoryProduct = "Category: Ropa";
                }
                else
                {
                    listItems[i].ImageProduct = Resources.comics1;
                    listItems[i].CategoryProduct = "Category: Comics";
                }
                flowLayoutPanel1.Controls.Add(listItems[i]);

            }

        }
    }
}
