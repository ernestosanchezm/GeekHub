using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekHub
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Panel01.ForeColor = Color.FromArgb(255, 239, 156);
           
        }

        private void cargarMetodos()
        {
            string Titulo, Link;
            Titulo = "whatsapp ";
            Link = "https://web.whatsapp.com/";
            string workingDirectory = Environment.CurrentDirectory;

            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            string image = projectDirectory + @"\Imagenes\wsplogo.png";
            int CantidadDeContactos = 3;

            Detail_Control[] Detalles = new Detail_Control[CantidadDeContactos];

            for (int i = 0; i < CantidadDeContactos; i++)
            {
                Detalles[i] = new Detail_Control(Titulo, image, Link);

                Panel01.Controls.Add(Detalles[i]);
            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void detail_Control1_Load(object sender, EventArgs e)
        {

        }

 
        private void detail_Control1_Load_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Panel01.Visible = true;
            cargarMetodos();

        }

        private void Contact_Methods_Click(object sender, EventArgs e)
        {

        }

        private void Panel01_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
