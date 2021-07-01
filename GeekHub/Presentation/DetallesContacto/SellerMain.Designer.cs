
namespace GeekHub.Presentation.DetallesContacto
{
    partial class SellerMain
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
            this.NombreProducto = new System.Windows.Forms.Label();
            this.ContactImage = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lbldt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreProducto
            // 
            this.NombreProducto.AccessibleName = "NombreProducto";
            this.NombreProducto.AllowDrop = true;
            this.NombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NombreProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NombreProducto.Location = new System.Drawing.Point(249, 15);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(195, 50);
            this.NombreProducto.TabIndex = 4;
            this.NombreProducto.Text = "NOMBRE";
            this.NombreProducto.Click += new System.EventHandler(this.NombreProducto_Click);
            // 
            // ContactImage
            // 
            this.ContactImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContactImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContactImage.ImageLocation = "";
            this.ContactImage.Location = new System.Drawing.Point(20, 15);
            this.ContactImage.Name = "ContactImage";
            this.ContactImage.Size = new System.Drawing.Size(223, 198);
            this.ContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ContactImage.TabIndex = 3;
            this.ContactImage.TabStop = false;
            this.ContactImage.Click += new System.EventHandler(this.ContactImage_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AllowDrop = true;
            this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(827, 96);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(140, 50);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.AccessibleName = "Name";
            this.lblprecio.AllowDrop = true;
            this.lblprecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblprecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblprecio.Location = new System.Drawing.Point(249, 96);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(184, 35);
            this.lblprecio.TabIndex = 7;
            this.lblprecio.Text = "PRECIO";
            this.lblprecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldt
            // 
            this.lbldt.AccessibleName = "Name";
            this.lbldt.AllowDrop = true;
            this.lbldt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbldt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldt.Location = new System.Drawing.Point(249, 162);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(217, 35);
            this.lbldt.TabIndex = 8;
            this.lbldt.Text = "FECHA PUBLICACION";
            this.lbldt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SellerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbldt);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.ContactImage);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "SellerMain";
            this.Size = new System.Drawing.Size(992, 224);
            this.Load += new System.EventHandler(this.SellerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label NombreProducto;
        private System.Windows.Forms.PictureBox ContactImage;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lbldt;
    }
}
