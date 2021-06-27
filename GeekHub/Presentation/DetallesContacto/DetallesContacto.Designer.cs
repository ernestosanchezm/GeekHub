
namespace GeekHub
{
    partial class Detail_Control
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
            this.NombreContacto = new System.Windows.Forms.Label();
            this.Btn_Contact = new System.Windows.Forms.Button();
            this.ContactImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreContacto
            // 
            this.NombreContacto.AccessibleName = "Name";
            this.NombreContacto.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreContacto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NombreContacto.Location = new System.Drawing.Point(143, 20);
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.Size = new System.Drawing.Size(359, 113);
            this.NombreContacto.TabIndex = 1;
            this.NombreContacto.Text = "CONTACTO";
            this.NombreContacto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NombreContacto.Click += new System.EventHandler(this.NombreContacto_Click);
            // 
            // Btn_Contact
            // 
            this.Btn_Contact.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Contact.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Contact.ForeColor = System.Drawing.Color.Black;
            this.Btn_Contact.Location = new System.Drawing.Point(508, 54);
            this.Btn_Contact.Name = "Btn_Contact";
            this.Btn_Contact.Size = new System.Drawing.Size(140, 50);
            this.Btn_Contact.TabIndex = 2;
            this.Btn_Contact.Text = "Contactar!";
            this.Btn_Contact.UseVisualStyleBackColor = false;
            this.Btn_Contact.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContactImage
            // 
            this.ContactImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContactImage.ImageLocation = "";
            this.ContactImage.Location = new System.Drawing.Point(15, 20);
            this.ContactImage.Name = "ContactImage";
            this.ContactImage.Size = new System.Drawing.Size(122, 113);
            this.ContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ContactImage.TabIndex = 0;
            this.ContactImage.TabStop = false;
            this.ContactImage.Click += new System.EventHandler(this.ContactImage_Click);
            // 
            // Detail_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Btn_Contact);
            this.Controls.Add(this.NombreContacto);
            this.Controls.Add(this.ContactImage);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Detail_Control";
            this.Size = new System.Drawing.Size(662, 160);
            this.Load += new System.EventHandler(this.Detail_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label NombreContacto;
        private System.Windows.Forms.Button Btn_Contact;
        private System.Windows.Forms.PictureBox ContactImage;
    }
}
