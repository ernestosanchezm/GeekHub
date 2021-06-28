
namespace GeekHub.Presentation.DetallesContacto
{
    partial class EditarContactos
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
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.ContactImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreContacto
            // 
            this.NombreContacto.AccessibleName = "Name";
            this.NombreContacto.BackColor = System.Drawing.Color.White;
            this.NombreContacto.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreContacto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NombreContacto.Location = new System.Drawing.Point(143, 24);
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.Size = new System.Drawing.Size(359, 113);
            this.NombreContacto.TabIndex = 4;
            this.NombreContacto.Text = "CONTACTO";
            this.NombreContacto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NombreContacto.Click += new System.EventHandler(this.NombreContacto_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.btn_Edit.Location = new System.Drawing.Point(508, 24);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(140, 50);
            this.btn_Edit.TabIndex = 5;
            this.btn_Edit.Text = "Editar";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.SystemColors.Control;
            this.btDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDel.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.ForeColor = System.Drawing.Color.Black;
            this.btDel.Location = new System.Drawing.Point(508, 87);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(140, 50);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Eliminar";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // ContactImage
            // 
            this.ContactImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContactImage.ImageLocation = "";
            this.ContactImage.Location = new System.Drawing.Point(15, 24);
            this.ContactImage.Name = "ContactImage";
            this.ContactImage.Size = new System.Drawing.Size(122, 113);
            this.ContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ContactImage.TabIndex = 3;
            this.ContactImage.TabStop = false;
            // 
            // EditarContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.NombreContacto);
            this.Controls.Add(this.ContactImage);
            this.Margin = new System.Windows.Forms.Padding(50, 10, 0, 10);
            this.Name = "EditarContactos";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Size = new System.Drawing.Size(660, 158);
            this.Load += new System.EventHandler(this.EditarContactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label NombreContacto;
        private System.Windows.Forms.PictureBox ContactImage;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btDel;
    }
}
