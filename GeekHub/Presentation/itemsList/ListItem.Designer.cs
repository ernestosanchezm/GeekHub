﻿
namespace GeekHub.Presentation.itemsList
{
    partial class ListItem
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
            this.lblCategoryProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryProduct
            // 
            this.lblCategoryProduct.AutoSize = true;
            this.lblCategoryProduct.Location = new System.Drawing.Point(5, 138);
            this.lblCategoryProduct.Name = "lblCategoryProduct";
            this.lblCategoryProduct.Size = new System.Drawing.Size(73, 17);
            this.lblCategoryProduct.TabIndex = 2;
            this.lblCategoryProduct.Text = "Category: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.lblCategoryProduct);
            this.panel1.Controls.Add(this.lblNameProduct);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(35, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 162);
            this.panel1.TabIndex = 3;
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoEllipsis = true;
            this.lblNameProduct.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblNameProduct.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNameProduct.Location = new System.Drawing.Point(3, 105);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(173, 33);
            this.lblNameProduct.TabIndex = 1;
            this.lblNameProduct.Text = "NameProduct";
            this.lblNameProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(247, 264);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}