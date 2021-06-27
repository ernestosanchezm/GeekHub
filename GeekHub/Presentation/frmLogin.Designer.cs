
namespace GeekHub
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txUser = new System.Windows.Forms.TextBox();
            this.lbPsw = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Vendedores = new System.Windows.Forms.Button();
            this.txPsw = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LOGO2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.lbPsw.AutoSize = true;
            this.lbPsw.BackColor = System.Drawing.Color.Transparent;
            this.lbPsw.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.lbPsw.Location = new System.Drawing.Point(50, 397);
            this.lbPsw.Name = "lbPsw";
            this.lbPsw.Size = new System.Drawing.Size(158, 30);
            this.lbPsw.TabIndex = 3;
            this.lbPsw.Text = "CONTRASEÑA :";
            // 
            // lbUser
            // 
            this.lbUser.AllowDrop = true;
            this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(84, 330);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(127, 40);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "CORREO";
            // 
            // btLogin
            // 
            this.btLogin.AllowDrop = true;
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.Font = new System.Drawing.Font("Quicksand", 10F);
            this.btLogin.ForeColor = System.Drawing.Color.Black;
            this.btLogin.Location = new System.Drawing.Point(64, 569);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(102, 73);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Ingresar";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.AllowDrop = true;
            this.btn_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.btn_Register.Font = new System.Drawing.Font("Quicksand", 10F);
            this.btn_Register.ForeColor = System.Drawing.Color.Black;
            this.btn_Register.Location = new System.Drawing.Point(232, 569);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(102, 73);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "Registrarse";
            this.btn_Register.UseVisualStyleBackColor = false;
            // 
            // btn_Vendedores
            // 
            this.btn_Vendedores.AllowDrop = true;
            this.btn_Vendedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Vendedores.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vendedores.Font = new System.Drawing.Font("Quicksand", 10F);
            this.btn_Vendedores.ForeColor = System.Drawing.Color.Black;
            this.btn_Vendedores.Location = new System.Drawing.Point(404, 569);
            this.btn_Vendedores.Name = "btn_Vendedores";
            this.btn_Vendedores.Size = new System.Drawing.Size(102, 73);
            this.btn_Vendedores.TabIndex = 8;
            this.btn_Vendedores.Text = "Ingreso de vendedores";
            this.btn_Vendedores.UseVisualStyleBackColor = false;
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
            this.txPsw.TextChanged += new System.EventHandler(this.txPsw_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Vendedores);
            this.panel1.Controls.Add(this.btn_Register);
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
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.LOGO2.ForeColor = System.Drawing.Color.Black;
            this.LOGO2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LOGO2.Location = new System.Drawing.Point(141, 195);
            this.LOGO2.Margin = new System.Windows.Forms.Padding(0);
            this.LOGO2.Name = "LOGO2";
            this.LOGO2.Size = new System.Drawing.Size(311, 89);
            this.LOGO2.TabIndex = 12;
            this.LOGO2.Text = "GEEKHUB";
            this.LOGO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.Label lbPsw;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Vendedores;
        private System.Windows.Forms.TextBox txPsw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LOGO2;
    }
}

