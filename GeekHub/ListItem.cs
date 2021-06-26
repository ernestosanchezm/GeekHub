﻿using System;
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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        #region Properties
        private string _nameProduct;
        private Image _imageProduct;

        [Category("Product props")]
        public string NameProduct
        {
            get { return _nameProduct; }
            set { _nameProduct = value; lblNameProduct.Text = value; }
        }
        [Category("Product props")]
        public Image ImageProduct
        {
            get { return _imageProduct; }
            set { _imageProduct= value; pictureBox1.Image = value; }
        }
        #endregion
    }
}