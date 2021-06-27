
namespace GeekHub.Presentation
{
    partial class frmViewProductsDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilterCategory = new System.Windows.Forms.Label();
            this.flowLayoutPanelOrden = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutFiltrosCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.bttLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttOptions = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelProduct
            // 
            this.flowLayoutPanelProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelProduct.AutoScroll = true;
            this.flowLayoutPanelProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelProduct.Location = new System.Drawing.Point(6, 170);
            this.flowLayoutPanelProduct.Name = "flowLayoutPanelProduct";
            this.flowLayoutPanelProduct.Size = new System.Drawing.Size(1321, 679);
            this.flowLayoutPanelProduct.TabIndex = 18;
            this.flowLayoutPanelProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelProduct_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Products Detail";
            // 
            // lblFilterCategory
            // 
            this.lblFilterCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFilterCategory.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lblFilterCategory.Location = new System.Drawing.Point(1403, 302);
            this.lblFilterCategory.Name = "lblFilterCategory";
            this.lblFilterCategory.Size = new System.Drawing.Size(158, 40);
            this.lblFilterCategory.TabIndex = 17;
            this.lblFilterCategory.Text = "Categoria";
            this.lblFilterCategory.Click += new System.EventHandler(this.lblFilterCategory_Click);
            // 
            // flowLayoutPanelOrden
            // 
            this.flowLayoutPanelOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelOrden.AutoScroll = true;
            this.flowLayoutPanelOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelOrden.Location = new System.Drawing.Point(1377, 170);
            this.flowLayoutPanelOrden.Name = "flowLayoutPanelOrden";
            this.flowLayoutPanelOrden.Size = new System.Drawing.Size(195, 129);
            this.flowLayoutPanelOrden.TabIndex = 16;
            // 
            // flowLayoutFiltrosCategory
            // 
            this.flowLayoutFiltrosCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutFiltrosCategory.AutoScroll = true;
            this.flowLayoutFiltrosCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutFiltrosCategory.Location = new System.Drawing.Point(1376, 345);
            this.flowLayoutFiltrosCategory.Name = "flowLayoutFiltrosCategory";
            this.flowLayoutFiltrosCategory.Size = new System.Drawing.Size(195, 504);
            this.flowLayoutFiltrosCategory.TabIndex = 15;
            // 
            // lblFiltros
            // 
            this.lblFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblFiltros.Location = new System.Drawing.Point(1426, 136);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(96, 31);
            this.lblFiltros.TabIndex = 14;
            this.lblFiltros.Text = "Filtros";
            this.lblFiltros.Click += new System.EventHandler(this.lblFiltros_Click);
            // 
            // bttLogOut
            // 
            this.bttLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttLogOut.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogOut.Location = new System.Drawing.Point(1333, -1);
            this.bttLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.bttLogOut.Name = "bttLogOut";
            this.bttLogOut.Size = new System.Drawing.Size(228, 123);
            this.bttLogOut.TabIndex = 3;
            this.bttLogOut.Text = "Cerrar sesion";
            this.bttLogOut.UseVisualStyleBackColor = true;
            this.bttLogOut.Click += new System.EventHandler(this.bttLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.bttLogOut);
            this.panel1.Controls.Add(this.bttOptions);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1562, 123);
            this.panel1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.textBox1.Location = new System.Drawing.Point(158, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(896, 68);
            this.textBox1.TabIndex = 4;
            // 
            // bttOptions
            // 
            this.bttOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttOptions.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttOptions.Location = new System.Drawing.Point(1099, 26);
            this.bttOptions.Margin = new System.Windows.Forms.Padding(2);
            this.bttOptions.Name = "bttOptions";
            this.bttOptions.Size = new System.Drawing.Size(202, 69);
            this.bttOptions.TabIndex = 2;
            this.bttOptions.Text = "Opciones";
            this.bttOptions.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GeekHub.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmViewProductsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFilterCategory);
            this.Controls.Add(this.flowLayoutPanelProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelOrden);
            this.Controls.Add(this.flowLayoutFiltrosCategory);
            this.Controls.Add(this.lblFiltros);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewProductsDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProductsDetail";
            this.Load += new System.EventHandler(this.frmViewProductsDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrden;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutFiltrosCategory;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Button bttLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttOptions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}