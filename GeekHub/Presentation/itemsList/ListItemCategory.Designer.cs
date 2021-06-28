
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoEllipsis = true;
            this.lblNameCategory.BackColor = System.Drawing.SystemColors.Control;
            this.lblNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNameCategory.Location = new System.Drawing.Point(22, 167);
            this.lblNameCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(138, 27);
            this.lblNameCategory.TabIndex = 3;
            this.lblNameCategory.Text = "Category";
            this.lblNameCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNameCategory.Click += new System.EventHandler(this.lblNameCategory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNameCategory);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListItemCategory";
            this.Size = new System.Drawing.Size(182, 211);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
