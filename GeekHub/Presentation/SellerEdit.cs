using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub.Presentation
{
    public partial class SellerEdit : Form
    {
        
        
        protected override void OnPaint(PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        public SellerEdit()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; 
            this.ControlBox = false;
            this.Text = String.Empty;
            pnlform.BackColor = Color.FromArgb(153, 153, 255);
            lblReg.ForeColor = Color.FromArgb(61, 61, 61);
            lblName.ForeColor = Color.FromArgb(61, 61, 61);
            label1.ForeColor = Color.FromArgb(61, 61, 61);
            label2.ForeColor = Color.FromArgb(61, 61, 61);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void SellerEdit_Load(object sender, EventArgs e)
        {

        }

        private void pnlform_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
