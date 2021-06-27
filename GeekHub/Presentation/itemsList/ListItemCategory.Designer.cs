
namespace GeekHub.Presentation.itemsList
{
    partial class ListItemCategory
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
            this.lblNameCategory = new System.Windows.Forms.Label();
            this.categoryImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoEllipsis = true;
            this.lblNameCategory.BackColor = System.Drawing.SystemColors.Control;
            this.lblNameCategory.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNameCategory.Location = new System.Drawing.Point(29, 205);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(184, 33);
            this.lblNameCategory.TabIndex = 3;
            this.lblNameCategory.Text = "Category";
            this.lblNameCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // categoryImage
            // 
            this.categoryImage.Location = new System.Drawing.Point(29, 23);
            this.categoryImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryImage.Name = "categoryImage";
            this.categoryImage.Size = new System.Drawing.Size(184, 180);
            this.categoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categoryImage.TabIndex = 2;
            this.categoryImage.TabStop = false;
            // 
            // ListItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNameCategory);
            this.Controls.Add(this.categoryImage);
            this.Name = "ListItemCategory";
            this.Size = new System.Drawing.Size(243, 260);
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameCategory;
        private System.Windows.Forms.PictureBox categoryImage;
    }
}
