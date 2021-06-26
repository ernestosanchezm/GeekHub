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
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ListItem();
                items[i].NameProduct = "name";

                flowLayoutPanel1.Controls.Add(items[i]);
            }

        }
    }
}
