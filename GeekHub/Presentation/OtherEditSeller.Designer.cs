
namespace GeekHub.Presentation
{
    partial class OtherEditSeller
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
            this.lblRecibo = new System.Windows.Forms.Label();
            this.lbExpiracion = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.CheckedListBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(267, 188);
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
            this.tbCorreo.Location = new System.Drawing.Point(267, 122);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(350, 32);
            this.tbCorreo.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 58);
            this.label1.TabIndex = 48;
            this.label1.Text = "CONTRASEÑA:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(29, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(219, 58);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "CORREO:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReg
            // 
            this.lblReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Font = new System.Drawing.Font("Quicksand", 25F, System.Drawing.FontStyle.Bold);
            this.lblReg.ForeColor = System.Drawing.Color.Black;
            this.lblReg.Location = new System.Drawing.Point(169, 14);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(302, 50);
            this.lblReg.TabIndex = 46;
            this.lblReg.Text = "Editar Privacidad";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // lblRecibo
            // 
            this.lblRecibo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecibo.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.lblRecibo.Location = new System.Drawing.Point(93, 384);
            this.lblRecibo.Name = "lblRecibo";
            this.lblRecibo.Size = new System.Drawing.Size(508, 51);
            this.lblRecibo.TabIndex = 51;
            this.lblRecibo.Text = "FECHA DE EXPIRACION DE MEMBRESIA";
            this.lblRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbExpiracion
            // 
            this.lbExpiracion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbExpiracion.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.lbExpiracion.Location = new System.Drawing.Point(55, 435);
            this.lbExpiracion.Name = "lbExpiracion";
            this.lbExpiracion.Size = new System.Drawing.Size(586, 51);
            this.lbExpiracion.TabIndex = 52;
            this.lbExpiracion.Text = "AQUI VA LA FECHA DE EXPIRACION DE LA BD";
            this.lbExpiracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DNI
            // 
            this.DNI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DNI.FormattingEnabled = true;
            this.DNI.Location = new System.Drawing.Point(267, 258);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(350, 49);
            this.DNI.TabIndex = 53;
            // 
            // lblDoc
            // 
            this.lblDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoc.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.lblDoc.Location = new System.Drawing.Point(15, 249);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(233, 58);
            this.lblDoc.TabIndex = 54;
            this.lblDoc.Text = "TIPO DE DOCUMENTO:";
            this.lblDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(77, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 58);
            this.label2.TabIndex = 55;
            this.label2.Text = "DOCUMENTO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(267, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 32);
            this.textBox2.TabIndex = 56;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(73, 518);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(135, 56);
            this.btnsave.TabIndex = 57;
            this.btnsave.Text = "GUARDAR";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(466, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 56);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GeekHub.Properties.Resources.lkl;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.DNI);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblReg);
            this.panel1.Controls.Add(this.tbCorreo);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbExpiracion);
            this.panel1.Controls.Add(this.lblDoc);
            this.panel1.Controls.Add(this.lblRecibo);
            this.panel1.Location = new System.Drawing.Point(67, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 590);
            this.panel1.TabIndex = 59;
            // 
            // OtherEditSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 621);
            this.Controls.Add(this.panel1);
            this.Name = "OtherEditSeller";
            this.Text = "OtherEditSeller";
            this.Load += new System.EventHandler(this.OtherEditSeller_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblRecibo;
        private System.Windows.Forms.Label lbExpiracion;
        private System.Windows.Forms.CheckedListBox DNI;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
    }
}