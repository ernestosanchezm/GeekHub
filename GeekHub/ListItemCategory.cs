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
    public partial class ListItemCategory : UserControl
    {
        public ListItemCategory()
        {
            InitializeComponent();
        }
        #region Properties
        private string _nameCategory;
        private Image _imageCategory;

        [Category("Category props")]
        public string NameCategory
        {
            get { return _nameCategory; }
            set { _nameCategory = value; lblNameCategory.Text = value; }
        }
        [Category("Category props")]
        public Image ImageCategory
        {
            get { return _imageCategory; }
            set { _imageCategory = value; pictureBox1.Image = value; }
        }
        #endregion
    }
}