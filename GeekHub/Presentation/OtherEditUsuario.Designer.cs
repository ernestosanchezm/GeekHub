
namespace GeekHub.Presentation
{
    partial class OtherEditUsuario
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.btncancel.Location = new System.Drawing.Point(362, 344);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(181, 79);
            this.btncancel.TabIndex = 61;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(91, 344);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(181, 79);
            this.btnsave.TabIndex = 60;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(247, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 32);
            this.textBox1.TabIndex = 59;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCorreo.BackColor = System.Drawing.Color.White;
            this.tbCorreo.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.ForeColor = System.Drawing.Color.Black;
            this.tbCorreo.Location = new System.Drawing.Point(247, 146);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(350, 32);
            this.tbCorreo.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 58);
            this.label1.TabIndex = 57;
            this.label1.Text = "CONTRASEÑA:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(84, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 58);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "CORREO:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReg
            // 
            this.lblReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.Black;
            this.lblReg.Location = new System.Drawing.Point(136, 30);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(353, 59);
            this.lblReg.TabIndex = 55;
            this.lblReg.Text = "Editar Privacidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GeekHub.Properties.Resources.lkl;
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.lblReg);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.tbCorreo);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 488);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // OtherEditUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 621);
            this.Controls.Add(this.panel1);
            this.Name = "OtherEditUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtherEditUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Panel panel1;
    }
}