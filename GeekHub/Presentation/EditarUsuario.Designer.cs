
namespace GeekHub.Presentation
{
    partial class EditarUsuario
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
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(341, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 32);
            this.textBox1.TabIndex = 50;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCorreo.BackColor = System.Drawing.Color.White;
            this.tbCorreo.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.ForeColor = System.Drawing.Color.Black;
            this.tbCorreo.Location = new System.Drawing.Point(341, 150);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(350, 32);
            this.tbCorreo.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 58);
            this.label1.TabIndex = 48;
            this.label1.Text = "APELLIDO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(63, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(219, 58);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "NOMBRE:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReg
            // 
            this.lblReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.Black;
            this.lblReg.Location = new System.Drawing.Point(212, 27);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(265, 59);
            this.lblReg.TabIndex = 46;
            this.lblReg.Text = "Editar Datos";
            // 
            // lbDni
            // 
            this.lbDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDni.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbDni.Location = new System.Drawing.Point(196, 291);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(86, 58);
            this.lbDni.TabIndex = 51;
            this.lbDni.Text = "DNI:";
            this.lbDni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(341, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 32);
            this.textBox2.TabIndex = 52;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(125, 414);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(181, 79);
            this.btnsave.TabIndex = 53;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.btncancel.Location = new System.Drawing.Point(510, 414);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(181, 79);
            this.btncancel.TabIndex = 54;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 621);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblReg);
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
    }
}