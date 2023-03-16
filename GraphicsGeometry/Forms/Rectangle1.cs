using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsGeometry.Forms
{
    public partial class Rectangle1 : Form
    {
        public Rectangle1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string h = textBox1.Text;
                string l = textBox2.Text;

                int H = int.Parse(h);
                int L = int.Parse(l);
                int Perimetr;

                int S;

                S = H * L;
                Perimetr = 2 * (L + H);

                label4.Text = "Площадь прямоугольника равна " + S;
                label3.Text = "Периметр прямоугольника равен " + Perimetr;
            }
            catch 
            {
                MessageBox.Show("Неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string h = textBox1.Text;
                string l = textBox2.Text;

                int H = int.Parse(h);
                int L = int.Parse(l);

                Pen myPen = new Pen(Color.Black, 1);
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                g.DrawRectangle(myPen, 500, 100, H, L);
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Rectangle1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
