using GraphicsGeometry.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsGeometry
{
    public partial class GG : Form
    {
        public GG()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Circle c = new Circle();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Square s = new Square();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Triangle t = new Triangle();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rectangle1 rectangle = new Rectangle1();
            rectangle.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ring ring = new Ring();
            ring.Show();
        }

        private void GG_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:\\учёба\\C#\\курсач\\GraphicsGeometry\\GraphicsGeometry\\bin\\Debug\\Logo.png");
            pictureBox2.Image = Image.FromFile("E:\\учёба\\C#\\курсач\\GraphicsGeometry\\GraphicsGeometry\\bin\\Debug\\waiting-meme.png");

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.Show();
        }
    }
}