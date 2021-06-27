
namespace GeekHub.Presentation.itemsList
{
    partial class ListItemProductDetail
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoEllipsis = true;
            this.lblNameProduct.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblNameProduct.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lblNameProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNameProduct.Location = new System.Drawing.Point(226, 11);
            this.lblNameProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(927, 52);
            this.lblNameProduct.TabIndex = 11;
            this.lblNameProduct.Text = "NameProduct";
            this.lblNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Quicksand", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPrice.Location = new System.Drawing.Point(382, 135);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 35);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "label4";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Quicksand", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCategory.Location = new System.Drawing.Point(382, 86);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 35);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(227, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Price:";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Quicksand", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label0.Location = new System.Drawing.Point(227, 86);
            this.label0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(137, 35);
            this.label0.TabIndex = 12;
            this.label0.Text = "Category: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ListItemProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListItemProductDetail";
            this.Size = new System.Drawing.Size(1167, 234);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
