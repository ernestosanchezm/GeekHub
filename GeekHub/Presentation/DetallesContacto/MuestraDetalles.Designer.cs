
namespace GeekHub.Presentation.DetallesContacto
{
    partial class DetallesContacto
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
            this.Contact_Methods = new System.Windows.Forms.Label();
            this.Panel01 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnclose = new System.Windows.Forms.Button();
            this.Panel01.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contact_Methods
            // 
            this.Contact_Methods.AccessibleName = "Contact_Mehods";
            this.Contact_Methods.AllowDrop = true;
            this.Contact_Methods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contact_Methods.AutoEllipsis = true;
            this.Contact_Methods.BackColor = System.Drawing.Color.Transparent;
            this.Contact_Methods.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Methods.ForeColor = System.Drawing.Color.White;
            this.Contact_Methods.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Contact_Methods.Location = new System.Drawing.Point(10, 10);
            this.Contact_Methods.Margin = new System.Windows.Forms.Padding(0);
            this.Contact_Methods.Name = "Contact_Methods";
            this.Contact_Methods.Size = new System.Drawing.Size(677, 52);
            this.Contact_Methods.TabIndex = 0;
            this.Contact_Methods.Text = "MEDIOS DE CONTACTO";
            this.Contact_Methods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Contact_Methods.Click += new System.EventHandler(this.Contact_Methods_Click);
            // 
            // Panel01
            // 
            this.Panel01.AllowDrop = true;
            this.Panel01.AutoScroll = true;
            this.Panel01.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel01.Controls.Add(this.Contact_Methods);
            this.Panel01.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Panel01.Location = new System.Drawing.Point(0, -1);
            this.Panel01.Margin = new System.Windows.Forms.Padding(100);
            this.Panel01.Name = "Panel01";
            this.Panel01.Padding = new System.Windows.Forms.Padding(10);
            this.Panel01.Size = new System.Drawing.Size(793, 320);
            this.Panel01.TabIndex = 2;
            this.Panel01.Visible = false;
            this.Panel01.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel01_Paint);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclose.BackgroundImage = global::GeekHub.Properties.Resources.btn;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.Location = new System.Drawing.Point(746, -1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(47, 40);
            this.btnclose.TabIndex = 1;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // DetallesContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 319);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.Panel01);
            this.Name = "DetallesContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel01.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Panel01;
        private System.Windows.Forms.Label Contact_Methods;
        private System.Windows.Forms.Button btnclose;
    }
}

