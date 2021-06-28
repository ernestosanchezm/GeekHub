
namespace GeekHub.Presentation
{
    partial class FrmEditContact
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
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Contact_Methods = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel.AutoScroll = true;
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.ForeColor = System.Drawing.Color.Black;
            this.Panel.Location = new System.Drawing.Point(0, 55);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(794, 569);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // Contact_Methods
            // 
            this.Contact_Methods.AccessibleName = "Contact_Mehods";
            this.Contact_Methods.AllowDrop = true;
            this.Contact_Methods.AutoEllipsis = true;
            this.Contact_Methods.BackColor = System.Drawing.Color.White;
            this.Contact_Methods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contact_Methods.Dock = System.Windows.Forms.DockStyle.Top;
            this.Contact_Methods.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Methods.ForeColor = System.Drawing.Color.Black;
            this.Contact_Methods.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Contact_Methods.Location = new System.Drawing.Point(0, 0);
            this.Contact_Methods.Margin = new System.Windows.Forms.Padding(0);
            this.Contact_Methods.Name = "Contact_Methods";
            this.Contact_Methods.Size = new System.Drawing.Size(794, 52);
            this.Contact_Methods.TabIndex = 1;
            this.Contact_Methods.Text = "MEDIOS DE CONTACTO";
            this.Contact_Methods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Contact_Methods.Click += new System.EventHandler(this.Contact_Methods_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclose.BackgroundImage = global::GeekHub.Properties.Resources.btn;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.Location = new System.Drawing.Point(745, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(47, 40);
            this.btnclose.TabIndex = 2;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // FrmEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 621);
            this.Controls.Add(this.Contact_Methods);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.Panel);
            this.Name = "FrmEditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditContact";
            this.Load += new System.EventHandler(this.FrmEditContact_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label Contact_Methods;
    }
}