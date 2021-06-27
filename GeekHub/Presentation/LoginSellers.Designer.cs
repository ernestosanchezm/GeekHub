
namespace GeekHub.Presentation
{
    partial class LoginSellers
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
            this.btn_Vendedores = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.txPsw = new System.Windows.Forms.TextBox();
            this.txUser = new System.Windows.Forms.TextBox();
            this.lbPsw = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsers = new System.Windows.Forms.Label();
            this.LOGO2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Vendedores
            // 
            this.btn_Vendedores.AllowDrop = true;
            this.btn_Vendedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Vendedores.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vendedores.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Vendedores.Font = new System.Drawing.Font("Quicksand", 10F);
            this.btn_Vendedores.ForeColor = System.Drawing.Color.Black;
            this.btn_Vendedores.Location = new System.Drawing.Point(393, 569);
            this.btn_Vendedores.Name = "btn_Vendedores";
            this.btn_Vendedores.Size = new System.Drawing.Size(102, 73);
            this.btn_Vendedores.TabIndex = 8;
            this.btn_Vendedores.Text = "Ingreso de usuarios";
            this.btn_Vendedores.UseVisualStyleBackColor = false;
            this.btn_Vendedores.Click += new System.EventHandler(this.btn_Vendedores_Click);
            // 
            // btLogin
            // 
            this.btLogin.AllowDrop = true;
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btLogin.Font = new System.Drawing.Font("Quicksand", 10F);
            this.btLogin.ForeColor = System.Drawing.Color.Black;
            this.btLogin.Location = new System.Drawing.Point(91, 569);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(102, 73);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Ingresar";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // txPsw
            // 
            this.txPsw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txPsw.BackColor = System.Drawing.Color.White;
            this.txPsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPsw.Font = new System.Drawing.Font("Quicksand", 15F);
            this.txPsw.Location = new System.Drawing.Point(217, 395);
            this.txPsw.Multiline = true;
            this.txPsw.Name = "txPsw";
            this.txPsw.PasswordChar = '*';
            this.txPsw.Size = new System.Drawing.Size(287, 41);
            this.txPsw.TabIndex = 9;
            // 
            // txUser
            // 
            this.txUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txUser.BackColor = System.Drawing.Color.White;
            this.txUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txUser.Font = new System.Drawing.Font("Quicksand", 15F);
            this.txUser.Location = new System.Drawing.Point(217, 330);
            this.txUser.Multiline = true;
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(287, 41);
            this.txUser.TabIndex = 0;
            // 
            // lbPsw
            // 
            this.lbPsw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPsw.AutoEllipsis = true;
            this.lbPsw.AutoSize = true;
            this.lbPsw.BackColor = System.Drawing.Color.Transparent;
            this.lbPsw.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.lbPsw.ForeColor = System.Drawing.Color.White;
            this.lbPsw.Location = new System.Drawing.Point(53, 397);
            this.lbPsw.Name = "lbPsw";
            this.lbPsw.Size = new System.Drawing.Size(158, 30);
            this.lbPsw.TabIndex = 3;
            this.lbPsw.Text = "CONTRASEÑA :";
            // 
            // lbUser
            // 
            this.lbUser.AllowDrop = true;
            this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUser.AutoEllipsis = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Location = new System.Drawing.Point(64, 330);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(147, 40);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "CORREO: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblUsers);
            this.panel1.Controls.Add(this.btn_Vendedores);
            this.panel1.Controls.Add(this.LOGO2);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.txPsw);
            this.panel1.Controls.Add(this.txUser);
            this.panel1.Controls.Add(this.lbPsw);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 861);
            this.panel1.TabIndex = 11;
            // 
            // lblUsers
            // 
            this.lblUsers.AccessibleName = "LOGO2";
            this.lblUsers.AllowDrop = true;
            this.lblUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsers.AutoEllipsis = true;
            this.lblUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblUsers.Font = new System.Drawing.Font("Quicksand", 40F, System.Drawing.FontStyle.Bold);
            this.lblUsers.ForeColor = System.Drawing.Color.White;
            this.lblUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUsers.Location = new System.Drawing.Point(77, 142);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(460, 170);
            this.lblUsers.TabIndex = 13;
            this.lblUsers.Text = "BIENVENIDO COMERCIANTE";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LOGO2
            // 
            this.LOGO2.AccessibleName = "LOGO2";
            this.LOGO2.AllowDrop = true;
            this.LOGO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOGO2.AutoEllipsis = true;
            this.LOGO2.AutoSize = true;
            this.LOGO2.BackColor = System.Drawing.Color.Transparent;
            this.LOGO2.Font = new System.Drawing.Font("Quicksand", 45F, System.Drawing.FontStyle.Bold);
            this.LOGO2.ForeColor = System.Drawing.Color.Lime;
            this.LOGO2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LOGO2.Location = new System.Drawing.Point(144, 39);
            this.LOGO2.Margin = new System.Windows.Forms.Padding(0);
            this.LOGO2.Name = "LOGO2";
            this.LOGO2.Size = new System.Drawing.Size(311, 89);
            this.LOGO2.TabIndex = 12;
            this.LOGO2.Text = "GEEKHUB";
            this.LOGO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginSellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeekHub.Properties.Resources.portada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel1);
            this.Name = "LoginSellers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginSellers";
            this.Load += new System.EventHandler(this.LoginSellers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Vendedores;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox txPsw;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.Label lbPsw;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label LOGO2;
    }
}