
namespace GeekHub.Presentation
{
    partial class frmSellerMain
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
            this.bttLogOut = new System.Windows.Forms.Button();
            this.bttOptions = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.Panel01 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttLogOut
            // 
            this.bttLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttLogOut.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogOut.Location = new System.Drawing.Point(1406, 11);
            this.bttLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.bttLogOut.Name = "bttLogOut";
            this.bttLogOut.Size = new System.Drawing.Size(154, 71);
            this.bttLogOut.TabIndex = 3;
            this.bttLogOut.Text = "Cerrar sesion";
            this.bttLogOut.UseVisualStyleBackColor = true;
            // 
            // bttOptions
            // 
            this.bttOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttOptions.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttOptions.Location = new System.Drawing.Point(1143, 13);
            this.bttOptions.Margin = new System.Windows.Forms.Padding(2);
            this.bttOptions.Name = "bttOptions";
            this.bttOptions.Size = new System.Drawing.Size(202, 69);
            this.bttOptions.TabIndex = 2;
            this.bttOptions.Text = "Opciones";
            this.bttOptions.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.textBox1.Location = new System.Drawing.Point(239, 158);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(830, 113);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.bttLogOut);
            this.panel1.Controls.Add(this.bttOptions);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1562, 93);
            this.panel1.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(856, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 69);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GeekHub.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Filtrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Filtrar.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filtrar.Location = new System.Drawing.Point(1097, 158);
            this.btn_Filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(462, 113);
            this.btn_Filtrar.TabIndex = 5;
            this.btn_Filtrar.Text = "FILTRAR POR NOMBRE";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // Panel01
            // 
            this.Panel01.AllowDrop = true;
            this.Panel01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel01.AutoScroll = true;
            this.Panel01.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel01.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Panel01.Location = new System.Drawing.Point(63, 308);
            this.Panel01.Margin = new System.Windows.Forms.Padding(100);
            this.Panel01.Name = "Panel01";
            this.Panel01.Padding = new System.Windows.Forms.Padding(10);
            this.Panel01.Size = new System.Drawing.Size(1496, 540);
            this.Panel01.TabIndex = 7;
            // 
            // frmSellerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.Panel01);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmSellerMain";
            this.Text = "frmSellerMain";
            this.Load += new System.EventHandler(this.frmSellerMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttLogOut;
        private System.Windows.Forms.Button bttOptions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.FlowLayoutPanel Panel01;
    }
}