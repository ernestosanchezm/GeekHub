
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
            this.productImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoEllipsis = true;
            this.lblNameProduct.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblNameProduct.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lblNameProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNameProduct.Location = new System.Drawing.Point(301, 14);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(1236, 64);
            this.lblNameProduct.TabIndex = 11;
            this.lblNameProduct.Text = "NameProduct";
            this.lblNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Quicksand", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPrice.Location = new System.Drawing.Point(509, 166);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(112, 44);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "label4";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Quicksand", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCategory.Location = new System.Drawing.Point(509, 106);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(107, 44);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(303, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "Price:";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Quicksand", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label0.Location = new System.Drawing.Point(303, 106);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(170, 44);
            this.label0.TabIndex = 12;
            this.label0.Text = "Category: ";
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(40, 18);
            this.productImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(247, 231);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // ListItemProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListItemProductDetail";
            this.Size = new System.Drawing.Size(1556, 288);
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.PictureBox productImage;
    }
}
