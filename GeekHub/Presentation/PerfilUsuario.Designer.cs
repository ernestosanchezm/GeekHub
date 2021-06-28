
namespace GeekHub.Presentation
{
    partial class PerfilUsuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttOptions = new System.Windows.Forms.Button();
            this.bttLogOut = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApell = new System.Windows.Forms.Label();
            this.btnEditDatos = new System.Windows.Forms.Button();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.btnEditFoto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bttOptions);
            this.panel1.Controls.Add(this.bttLogOut);
            this.panel1.Location = new System.Drawing.Point(11, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1562, 176);
            this.panel1.TabIndex = 21;
            // 
            // btHome
            // 
            this.btHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHome.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.Location = new System.Drawing.Point(897, 37);
            this.btHome.Margin = new System.Windows.Forms.Padding(2);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(202, 69);
            this.btHome.TabIndex = 13;
            this.btHome.Text = "Inicio";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GeekHub.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bttOptions
            // 
            this.bttOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttOptions.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttOptions.Location = new System.Drawing.Point(1114, 37);
            this.bttOptions.Margin = new System.Windows.Forms.Padding(2);
            this.bttOptions.Name = "bttOptions";
            this.bttOptions.Size = new System.Drawing.Size(202, 69);
            this.bttOptions.TabIndex = 2;
            this.bttOptions.Text = "Opciones";
            this.bttOptions.UseVisualStyleBackColor = true;
            this.bttOptions.Click += new System.EventHandler(this.bttOptions_Click);
            // 
            // bttLogOut
            // 
            this.bttLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttLogOut.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogOut.Location = new System.Drawing.Point(1330, 14);
            this.bttLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.bttLogOut.Name = "bttLogOut";
            this.bttLogOut.Size = new System.Drawing.Size(228, 123);
            this.bttLogOut.TabIndex = 3;
            this.bttLogOut.Text = "Cerrar sesion";
            this.bttLogOut.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(435, 613);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(521, 74);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "NOMBRE COMPLETO";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApell
            // 
            this.lblApell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApell.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold);
            this.lblApell.Location = new System.Drawing.Point(367, 687);
            this.lblApell.Name = "lblApell";
            this.lblApell.Size = new System.Drawing.Size(654, 70);
            this.lblApell.TabIndex = 25;
            this.lblApell.Text = "APELLIDO";
            this.lblApell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditDatos
            // 
            this.btnEditDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditDatos.BackgroundImage = global::GeekHub.Properties.Resources.edit;
            this.btnEditDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditDatos.Location = new System.Drawing.Point(631, 772);
            this.btnEditDatos.Name = "btnEditDatos";
            this.btnEditDatos.Size = new System.Drawing.Size(93, 77);
            this.btnEditDatos.TabIndex = 26;
            this.btnEditDatos.UseVisualStyleBackColor = true;
            this.btnEditDatos.Click += new System.EventHandler(this.btnEditDatos_Click);
            // 
            // pbPerfil
            // 
            this.pbPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pbPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPerfil.Location = new System.Drawing.Point(338, 205);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(705, 393);
            this.pbPerfil.TabIndex = 23;
            this.pbPerfil.TabStop = false;
            // 
            // btnEditFoto
            // 
            this.btnEditFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnEditFoto.BackgroundImage = global::GeekHub.Properties.Resources.edit;
            this.btnEditFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditFoto.Location = new System.Drawing.Point(986, 541);
            this.btnEditFoto.Name = "btnEditFoto";
            this.btnEditFoto.Size = new System.Drawing.Size(57, 57);
            this.btnEditFoto.TabIndex = 27;
            this.btnEditFoto.UseVisualStyleBackColor = false;
            this.btnEditFoto.Click += new System.EventHandler(this.btnEditFoto_Click);
            // 
            // PerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditFoto);
            this.Controls.Add(this.btnEditDatos);
            this.Controls.Add(this.lblApell);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbPerfil);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "PerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerfilUsuario";
            this.Load += new System.EventHandler(this.PerfilUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttOptions;
        private System.Windows.Forms.Button bttLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApell;
        private System.Windows.Forms.Button btnEditDatos;
        private System.Windows.Forms.Button btnEditFoto;
        private System.Windows.Forms.Button btHome;
    }
}