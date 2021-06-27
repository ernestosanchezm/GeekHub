
namespace GeekHub.Presentation
{
    partial class DetalleProducto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttLogOut = new System.Windows.Forms.Button();
            this.bttOptions = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lbN = new System.Windows.Forms.Label();
            this.lbNProducto = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbdscfc = new System.Windows.Forms.Label();
            this.lbdscFech = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbQdesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbSendPrice = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.lbSeller = new System.Windows.Forms.Label();
            this.bt_SelProf = new System.Windows.Forms.Button();
            this.bt_contactos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 21;
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
            this.bttOptions.Click += new System.EventHandler(this.bttOptions_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbProduct.Location = new System.Drawing.Point(13, 167);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(882, 682);
            this.pbProduct.TabIndex = 22;
            this.pbProduct.TabStop = false;
            // 
            // lbN
            // 
            this.lbN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbN.Location = new System.Drawing.Point(1065, 167);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(138, 40);
            this.lbN.TabIndex = 23;
            this.lbN.Text = "Nombre: ";
            // 
            // lbNProducto
            // 
            this.lbNProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNProducto.AutoSize = true;
            this.lbNProducto.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbNProducto.Location = new System.Drawing.Point(1245, 167);
            this.lbNProducto.Name = "lbNProducto";
            this.lbNProducto.Size = new System.Drawing.Size(285, 40);
            this.lbNProducto.TabIndex = 24;
            this.lbNProducto.Text = "NOMBRE PRODUCTO";
            // 
            // lbC
            // 
            this.lbC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbC.Location = new System.Drawing.Point(1050, 244);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(153, 40);
            this.lbC.TabIndex = 25;
            this.lbC.Text = "Categoria:";
            // 
            // lbCategory
            // 
            this.lbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbCategory.Location = new System.Drawing.Point(1245, 244);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(318, 40);
            this.lbCategory.TabIndex = 26;
            this.lbCategory.Text = "CATEGORIA PRODUCTO";
            // 
            // lbdscfc
            // 
            this.lbdscfc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbdscfc.AutoSize = true;
            this.lbdscfc.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbdscfc.Location = new System.Drawing.Point(901, 323);
            this.lbdscfc.Name = "lbdscfc";
            this.lbdscfc.Size = new System.Drawing.Size(302, 40);
            this.lbdscfc.TabIndex = 27;
            this.lbdscfc.Text = "Descuento por Fecha:";
            // 
            // lbdscFech
            // 
            this.lbdscFech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbdscFech.AutoSize = true;
            this.lbdscFech.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbdscFech.Location = new System.Drawing.Point(1245, 323);
            this.lbdscFech.Name = "lbdscFech";
            this.lbdscFech.Size = new System.Drawing.Size(237, 40);
            this.lbdscFech.TabIndex = 28;
            this.lbdscFech.Text = "descuento si hay";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1033, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 40);
            this.label3.TabIndex = 29;
            this.label3.Text = "Descuento :";
            // 
            // lbQdesc
            // 
            this.lbQdesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbQdesc.AutoSize = true;
            this.lbQdesc.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbQdesc.Location = new System.Drawing.Point(1245, 386);
            this.lbQdesc.Name = "lbQdesc";
            this.lbQdesc.Size = new System.Drawing.Size(237, 40);
            this.lbQdesc.TabIndex = 30;
            this.lbQdesc.Text = "descuento si hay";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1099, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 40);
            this.label5.TabIndex = 31;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1022, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 40);
            this.label6.TabIndex = 32;
            this.label6.Text = "Precio Envio:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbPrice.Location = new System.Drawing.Point(1245, 449);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(98, 40);
            this.lbPrice.TabIndex = 33;
            this.lbPrice.Text = "precio";
            // 
            // lbSendPrice
            // 
            this.lbSendPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSendPrice.AutoSize = true;
            this.lbSendPrice.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbSendPrice.Location = new System.Drawing.Point(1245, 507);
            this.lbSendPrice.Name = "lbSendPrice";
            this.lbSendPrice.Size = new System.Drawing.Size(98, 40);
            this.lbSendPrice.TabIndex = 34;
            this.lbSendPrice.Text = "precio";
            // 
            // lbS
            // 
            this.lbS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbS.Location = new System.Drawing.Point(1090, 574);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(113, 40);
            this.lbS.TabIndex = 35;
            this.lbS.Text = "Tienda:";
            this.lbS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbS.Click += new System.EventHandler(this.lbS_Click);
            // 
            // lbSeller
            // 
            this.lbSeller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSeller.AutoSize = true;
            this.lbSeller.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbSeller.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbSeller.Location = new System.Drawing.Point(1245, 574);
            this.lbSeller.Name = "lbSeller";
            this.lbSeller.Size = new System.Drawing.Size(234, 40);
            this.lbSeller.TabIndex = 36;
            this.lbSeller.Text = "NOMBRE TIENDA";
            // 
            // bt_SelProf
            // 
            this.bt_SelProf.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.bt_SelProf.Location = new System.Drawing.Point(1006, 675);
            this.bt_SelProf.Name = "bt_SelProf";
            this.bt_SelProf.Size = new System.Drawing.Size(197, 97);
            this.bt_SelProf.TabIndex = 37;
            this.bt_SelProf.Text = "PERFIL DE LA TIENDA";
            this.bt_SelProf.UseVisualStyleBackColor = true;
            // 
            // bt_contactos
            // 
            this.bt_contactos.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.bt_contactos.Location = new System.Drawing.Point(1282, 675);
            this.bt_contactos.Name = "bt_contactos";
            this.bt_contactos.Size = new System.Drawing.Size(197, 97);
            this.bt_contactos.TabIndex = 38;
            this.bt_contactos.Text = "Medios de Contacto";
            this.bt_contactos.UseVisualStyleBackColor = true;
            // 
            // DetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.bt_contactos);
            this.Controls.Add(this.bt_SelProf);
            this.Controls.Add(this.lbSeller);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.lbSendPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbQdesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbdscFech);
            this.Controls.Add(this.lbdscfc);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbNProducto);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.panel1);
            this.Name = "DetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttLogOut;
        private System.Windows.Forms.Button bttOptions;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbNProducto;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbdscfc;
        private System.Windows.Forms.Label lbdscFech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbQdesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbSendPrice;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lbSeller;
        private System.Windows.Forms.Button bt_SelProf;
        private System.Windows.Forms.Button bt_contactos;
    }
}