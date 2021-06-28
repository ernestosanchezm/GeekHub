
namespace GeekHub.Presentation.DetallesContacto
{
    partial class EditarContacto
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
            this.lblName = new System.Windows.Forms.Label();
            this.lbContact = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEdt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(45, 202);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(163, 58);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "TIPO:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbContact
            // 
            this.lbContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbContact.BackColor = System.Drawing.Color.Transparent;
            this.lbContact.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.lbContact.Location = new System.Drawing.Point(45, 103);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(170, 58);
            this.lbContact.TabIndex = 57;
            this.lbContact.Text = "CONTACTO:";
            this.lbContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbContact.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.btncancel.Location = new System.Drawing.Point(390, 358);
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
            this.btnsave.Location = new System.Drawing.Point(52, 358);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(181, 79);
            this.btnsave.TabIndex = 60;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tbContact
            // 
            this.tbContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbContact.BackColor = System.Drawing.Color.White;
            this.tbContact.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.ForeColor = System.Drawing.Color.Black;
            this.tbContact.Location = new System.Drawing.Point(221, 216);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(350, 32);
            this.tbContact.TabIndex = 59;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 38);
            this.comboBox1.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GeekHub.Properties.Resources.lkl;
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lbContact);
            this.panel1.Controls.Add(this.lbEdt);
            this.panel1.Controls.Add(this.tbContact);
            this.panel1.Location = new System.Drawing.Point(76, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 491);
            this.panel1.TabIndex = 63;
            // 
            // lbEdt
            // 
            this.lbEdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEdt.AutoSize = true;
            this.lbEdt.BackColor = System.Drawing.Color.Transparent;
            this.lbEdt.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdt.ForeColor = System.Drawing.Color.Black;
            this.lbEdt.Location = new System.Drawing.Point(190, 28);
            this.lbEdt.Name = "lbEdt";
            this.lbEdt.Size = new System.Drawing.Size(328, 59);
            this.lbEdt.TabIndex = 46;
            this.lbEdt.Text = "Editar Contacto";
            this.lbEdt.Click += new System.EventHandler(this.label3_Click);
            // 
            // EditarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 621);
            this.Controls.Add(this.panel1);
            this.Name = "EditarContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarContacto";
            this.Load += new System.EventHandler(this.EditarContacto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEdt;
    }
}