
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleProducto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bttLogOut = new System.Windows.Forms.Button();
            this.bttOptions = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.lbN = new System.Windows.Forms.Label();
            this.lbNProducto = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.bttLogOut);
            this.panel1.Controls.Add(this.bttOptions);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1562, 123);
            this.panel1.TabIndex = 21;
            // 
            // btHome
            // 
            this.btHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHome.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.Location = new System.Drawing.Point(874, 25);
            this.btHome.Margin = new System.Windows.Forms.Padding(2);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(202, 69);
            this.btHome.TabIndex = 7;
            this.btHome.Text = "Inicio";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tbSearch.Location = new System.Drawing.Point(112, 26);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(732, 68);
            this.tbSearch.TabIndex = 6;
            // 
            // bttLogOut
            // 
            this.bttLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogOut.Location = new System.Drawing.Point(1333, -1);
            this.bttLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.bttLogOut.Name = "bttLogOut";
            this.bttLogOut.Size = new System.Drawing.Size(228, 123);
            this.bttLogOut.TabIndex = 3;
            this.bttLogOut.Text = "Cerrar sesion";
            this.bttLogOut.UseVisualStyleBackColor = true;
            this.bttLogOut.Click += new System.EventHandler(this.bttLogOut_Click);
            // 
            // bttOptions
            // 
            this.bttOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pbProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbProduct.BackgroundImage")));
            this.pbProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProduct.ImageLocation = "C:\\Users\\User\\Desktop\\.NET\\PAGINA WEB\\GeekHub\\GeekHub_WS\\Fileserver\\Productos\\p_0" +
    "2_01.jpg";
            this.pbProduct.Location = new System.Drawing.Point(12, 167);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(882, 682);
            this.pbProduct.TabIndex = 22;
            this.pbProduct.TabStop = false;
            // 
            // lbN
            // 
            this.lbN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbN.Location = new System.Drawing.Point(1065, 167);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(133, 31);
            this.lbN.TabIndex = 23;
            this.lbN.Text = "Nombre: ";
            // 
            // lbNProducto
            // 
            this.lbNProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNProducto.AutoSize = true;
            this.lbNProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbNProducto.Location = new System.Drawing.Point(1245, 167);
            this.lbNProducto.Name = "lbNProducto";
            this.lbNProducto.Size = new System.Drawing.Size(331, 31);
            this.lbNProducto.TabIndex = 24;
            this.lbNProducto.Text = "RAMEN INSTANTANEO";
            // 
            // lbC
            // 
            this.lbC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbC.Location = new System.Drawing.Point(1050, 244);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(150, 31);
            this.lbC.TabIndex = 25;
            this.lbC.Text = "Categoria:";
            // 
            // lbCategory
            // 
            this.lbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbCategory.Location = new System.Drawing.Point(1245, 244);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(270, 31);
            this.lbCategory.TabIndex = 26;
            this.lbCategory.Text = "COMIDA ASIATICA";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1099, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1022, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "Precio Envio:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbPrice.Location = new System.Drawing.Point(1245, 449);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(90, 31);
            this.lbPrice.TabIndex = 33;
            this.lbPrice.Text = "S/ 20 ";
            // 
            // lbSendPrice
            // 
            this.lbSendPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSendPrice.AutoSize = true;
            this.lbSendPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbSendPrice.Location = new System.Drawing.Point(1245, 507);
            this.lbSendPrice.Name = "lbSendPrice";
            this.lbSendPrice.Size = new System.Drawing.Size(46, 31);
            this.lbSendPrice.TabIndex = 34;
            this.lbSendPrice.Text = "10";
            // 
            // lbS
            // 
            this.lbS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbS.Location = new System.Drawing.Point(1090, 574);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(112, 31);
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
            this.lbSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbSeller.Location = new System.Drawing.Point(1245, 574);
            this.lbSeller.Name = "lbSeller";
            this.lbSeller.Size = new System.Drawing.Size(279, 31);
            this.lbSeller.TabIndex = 36;
            this.lbSeller.Text = "KAMI SAMA STORE";
            // 
            // bt_SelProf
            // 
            this.bt_SelProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.bt_SelProf.Location = new System.Drawing.Point(1006, 675);
            this.bt_SelProf.Name = "bt_SelProf";
            this.bt_SelProf.Size = new System.Drawing.Size(197, 97);
            this.bt_SelProf.TabIndex = 37;
            this.bt_SelProf.Text = "PERFIL DE LA TIENDA";
            this.bt_SelProf.UseVisualStyleBackColor = true;
            this.bt_SelProf.Click += new System.EventHandler(this.bt_SelProf_Click);
            // 
            // bt_contactos
            // 
            this.bt_contactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.bt_contactos.Location = new System.Drawing.Point(1282, 675);
            this.bt_contactos.Name = "bt_contactos";
            this.bt_contactos.Size = new System.Drawing.Size(197, 97);
            this.bt_contactos.TabIndex = 38;
            this.bt_contactos.Text = "Medios de Contacto";
            this.bt_contactos.UseVisualStyleBackColor = true;
            this.bt_contactos.Click += new System.EventHandler(this.bt_contactos_Click);
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
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbNProducto);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.panel1);
            this.Name = "DetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleProducto";
            this.Load += new System.EventHandler(this.DetalleProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttLogOut;
        private System.Windows.Forms.Button bttOptions;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbNProducto;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbSendPrice;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lbSeller;
        private System.Windows.Forms.Button bt_SelProf;
        private System.Windows.Forms.Button bt_contactos;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.TextBox tbSearch;
    }
}
