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
            //loop through each item
            for (int i = 0; i < this.listItems.Count; i++)
            {
                this.listItems[i].NameProduct = "name";
            }

        }
    }
}
