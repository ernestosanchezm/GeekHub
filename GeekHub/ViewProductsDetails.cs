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
    public partial class ViewProductsDetails : Form
    {
        List<ListItemProductDetail> listProductsDetail;
        List<RadioButton> listFilterCategories;
        List<string> categories;
        public ViewProductsDetails()
        {
            InitializeComponent();
            instanceListItems();
            instanceListFilterCategory();
        }
        private void ListViewProductsDetails_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void instanceListItems()
        {
            this.listProductsDetail = new List<ListItemProductDetail>();
            for (int i = 0; i < 20; i++)
            {
                this.listProductsDetail.Add(new ListItemProductDetail());
            }
        }
        private void instanceListFilterCategory()
        {
            categories = new List<string>();
            listFilterCategories = new List<RadioButton>(); 

            categories.Add("Ropa");
            categories.Add("Comida Asiatica");
            categories.Add("Celulares");
            categories.Add("Figuras");
            categories.Add("Mangas");
            categories.Add("Lighstick Kpop");
            categories.Add("Disco Kpop");
            categories.Add("Animes Físicos");
            categories.Add("Webtoons Físicos");
            categories.Add("Merchandising de Anime");
            categories.Add("Merchandising de Kpop");
            categories.Add("Merchandising de Comics");
            for (int i = 0; i < categories.Count; i++)
            {
                listFilterCategories.Add(new RadioButton());
                listFilterCategories[i].Text = categories[i];
                flowLayoutFiltrosCategory.Controls.Add(listFilterCategories[i]);
            }

        }
        private void populateItems()
        {
            //loop through each item
            for (int i = 0; i < listProductsDetail.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listProductsDetail[i].NameProduct = "name";
                    listProductsDetail[i].CategoryProduct = "Ropa";
                    listProductsDetail[i].PriceProduct = "25";
                    listProductsDetail[i].DescuentoProducto = "225";
                    listProductsDetail[i].DetailProduct = "Detail products";
                    listProductsDetail[i].ImageProduct = Resources.ropa1;
                }
                else
                {
                    listProductsDetail[i].NameProduct = "name";
                    listProductsDetail[i].CategoryProduct = "Manga";
                    listProductsDetail[i].PriceProduct = "25";
                    listProductsDetail[i].DescuentoProducto = "225";
                    listProductsDetail[i].DetailProduct = "Detail products";
                    listProductsDetail[i].ImageProduct = Resources.manga1;
                }
                flowLayoutPanelProduct.Controls.Add(listProductsDetail[i]);

            }

        }


    }
}
