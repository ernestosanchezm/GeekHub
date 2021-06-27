
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
            this.txUser = new System.Windows.Forms.TextBox();
            this.txPsw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPsw = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(273, 135);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(100, 20);
            this.txUser.TabIndex = 0;
            // 
            // txPsw
            // 
            this.txPsw.Location = new System.Drawing.Point(273, 182);
            this.txPsw.Name = "txPsw";
            this.txPsw.Size = new System.Drawing.Size(100, 20);
            this.txPsw.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // lbPsw
            // 
            this.lbPsw.AutoSize = true;
            this.lbPsw.Location = new System.Drawing.Point(188, 189);
            this.lbPsw.Name = "lbPsw";
            this.lbPsw.Size = new System.Drawing.Size(61, 13);
            this.lbPsw.TabIndex = 3;
            this.lbPsw.Text = "Contraseña";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(188, 135);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(43, 13);
            this.lbUser.TabIndex = 5;
            this.lbUser.Text = "Usuario";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(174, 254);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Iniciar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbPsw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txPsw);
            this.Controls.Add(this.txUser);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.TextBox txPsw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPsw;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button button2;
    }
}

