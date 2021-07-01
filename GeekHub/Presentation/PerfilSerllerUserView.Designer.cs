
namespace GeekHub.Presentation
{
    partial class PerfilSerllerUserView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.bttLogOut = new System.Windows.Forms.Button();
            this.bttOptions = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel01 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDir = new System.Windows.Forms.Label();
            this.btnContact = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.bttLogOut);
            this.panel1.Controls.Add(this.bttOptions);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1562, 123);
            this.panel1.TabIndex = 22;
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
            this.btHome.TabIndex = 5;
            this.btHome.Text = "Inicio";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
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
            this.bttLogOut.Click += new System.EventHandler(this.bttLogOut_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 74);
            this.label1.TabIndex = 31;
            this.label1.Text = "PRODUTOS A LA VENTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Panel01
            // 
            this.Panel01.AllowDrop = true;
            this.Panel01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel01.AutoScroll = true;
            this.Panel01.BackColor = System.Drawing.Color.White;
            this.Panel01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel01.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Panel01.Location = new System.Drawing.Point(12, 499);
            this.Panel01.Margin = new System.Windows.Forms.Padding(100);
            this.Panel01.Name = "Panel01";
            this.Panel01.Padding = new System.Windows.Forms.Padding(10);
            this.Panel01.Size = new System.Drawing.Size(1496, 353);
            this.Panel01.TabIndex = 30;
            // 
            // pbPerfil
            // 
            this.pbPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pbPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPerfil.Location = new System.Drawing.Point(19, 155);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(270, 270);
            this.pbPerfil.TabIndex = 32;
            this.pbPerfil.TabStop = false;
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNombre.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold);
            this.lbNombre.Location = new System.Drawing.Point(331, 155);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(715, 74);
            this.lbNombre.TabIndex = 33;
            this.lbNombre.Text = "KAMI STORE";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDir
            // 
            this.lbDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDir.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold);
            this.lbDir.Location = new System.Drawing.Point(331, 254);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(1032, 74);
            this.lbDir.TabIndex = 34;
            this.lbDir.Text = "AV.  PERU 1020";
            this.lbDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnContact
            // 
            this.btnContact.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.btnContact.Location = new System.Drawing.Point(341, 359);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(347, 60);
            this.btnContact.TabIndex = 35;
            this.btnContact.Text = "METODOS DE CONTACTO";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.button1_Click);
            // 
            // PerfilSerllerUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.lbDir);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel01);
            this.Controls.Add(this.panel1);
            this.Name = "PerfilSerllerUserView";
            this.Text = "PerfilSerllerUserView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttLogOut;
        private System.Windows.Forms.Button bttOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Panel01;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDir;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btHome;
    }
}