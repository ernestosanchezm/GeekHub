
namespace GeekHub.Presentation
{
    partial class SoporteTecnico
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblnc = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.body);
            this.panel2.Controls.Add(this.lblReg);
            this.panel2.Controls.Add(this.lblnc);
            this.panel2.Location = new System.Drawing.Point(20, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 535);
            this.panel2.TabIndex = 41;
            // 
            // lblReg
            // 
            this.lblReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.Transparent;
            this.lblReg.Font = new System.Drawing.Font("Quicksand", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.Color.Black;
            this.lblReg.Location = new System.Drawing.Point(173, 23);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(386, 59);
            this.lblReg.TabIndex = 39;
            this.lblReg.Text = "SOPORTE TECNICO";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // lblnc
            // 
            this.lblnc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblnc.AutoSize = true;
            this.lblnc.BackColor = System.Drawing.Color.Transparent;
            this.lblnc.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnc.ForeColor = System.Drawing.Color.Black;
            this.lblnc.Location = new System.Drawing.Point(3, 116);
            this.lblnc.Name = "lblnc";
            this.lblnc.Size = new System.Drawing.Size(212, 30);
            this.lblnc.TabIndex = 36;
            this.lblnc.Text = "INGRESE PROBLEMA:";
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(23, 158);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(678, 250);
            this.body.TabIndex = 40;
            this.body.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(23, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 69);
            this.button1.TabIndex = 41;
            this.button1.Text = "ENVIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Quicksand", 20F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(515, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 69);
            this.button2.TabIndex = 42;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SoporteTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 621);
            this.Controls.Add(this.panel2);
            this.Name = "SoporteTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoporteTecnico";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblnc;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}