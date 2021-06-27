
namespace GeekHub.Presentation
{
    partial class frmMainView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttLogOut = new System.Windows.Forms.Button();
            this.bttOptions = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GeekHub.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.AutoScroll = true;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(12, 132);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(776, 306);
            this.flowLayoutPanelProducts.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttLogOut);
            this.panel1.Controls.Add(this.bttOptions);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 80);
            this.panel1.TabIndex = 2;
            // 
            // bttLogOut
            // 
            this.bttLogOut.Location = new System.Drawing.Point(619, 23);
            this.bttLogOut.Name = "bttLogOut";
            this.bttLogOut.Size = new System.Drawing.Size(141, 23);
            this.bttLogOut.TabIndex = 3;
            this.bttLogOut.Text = "Cerrar sesion";
            this.bttLogOut.UseVisualStyleBackColor = true;
            // 
            // bttOptions
            // 
            this.bttOptions.Location = new System.Drawing.Point(531, 23);
            this.bttOptions.Name = "bttOptions";
            this.bttOptions.Size = new System.Drawing.Size(82, 23);
            this.bttOptions.TabIndex = 2;
            this.bttOptions.Text = "Opciones";
            this.bttOptions.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Products";
            // 
            // frmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelProducts);
            this.Name = "frmMainView";
            this.Text = "frmMainView";
            this.Load += new System.EventHandler(this.frmMainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttLogOut;
        private System.Windows.Forms.Button bttOptions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}