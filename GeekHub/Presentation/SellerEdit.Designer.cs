
namespace GeekHub.Presentation
{
    partial class SellerEdit
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
            this.lblReg = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlform = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlform.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReg
            // 
            this.lblReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.Black;
            this.lblReg.Location = new System.Drawing.Point(251, 24);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(265, 59);
            this.lblReg.TabIndex = 40;
            this.lblReg.Text = "Editar Datos";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(162, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 58);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "NOMBRE";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(151, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 58);
            this.label1.TabIndex = 42;
            this.label1.Text = "APELLIDO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 53);
            this.label2.TabIndex = 43;
            this.label2.Text = "NOMBRE DE TIENDA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCorreo.BackColor = System.Drawing.Color.White;
            this.tbCorreo.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.ForeColor = System.Drawing.Color.Black;
            this.tbCorreo.Location = new System.Drawing.Point(383, 151);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(329, 32);
            this.tbCorreo.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(383, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 32);
            this.textBox1.TabIndex = 45;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(342, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 32);
            this.textBox2.TabIndex = 46;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.btnsave.Location = new System.Drawing.Point(23, 394);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(195, 88);
            this.btnsave.TabIndex = 47;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(470, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 88);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlform
            // 
            this.pnlform.Controls.Add(this.panel1);
            this.pnlform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlform.Location = new System.Drawing.Point(0, 0);
            this.pnlform.Name = "pnlform";
            this.pnlform.Size = new System.Drawing.Size(794, 621);
            this.pnlform.TabIndex = 50;
            this.pnlform.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlform_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GeekHub.Properties.Resources.lkl;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblReg);
            this.panel1.Location = new System.Drawing.Point(41, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 551);
            this.panel1.TabIndex = 50;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SellerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 621);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.pnlform);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellerEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerEdit";
            this.Load += new System.EventHandler(this.SellerEdit_Load);
            this.pnlform.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlform;
        private System.Windows.Forms.Panel panel1;
    }
}