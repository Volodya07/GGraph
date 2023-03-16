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
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string A = textBox1.Text;
                string B = textBox2.Text;
                string C = textBox3.Text;

                int a = Convert.ToInt32(A);
                int b = Convert.ToInt32(B);
                int c = Convert.ToInt32(C);

                int halfPerm = (a + b + c) / 2;

                int S = (int)Math.Sqrt(halfPerm * (halfPerm - a) * (halfPerm - b) * (halfPerm - c));

                label4.Text = "Площадь треугодьника равна " + S; 
            }
            catch 
            {
                MessageBox.Show("Неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string A = textBox1.Text;
                string B = textBox2.Text;
                string C = textBox3.Text;

                int a = Convert.ToInt32(A);
                int b = Convert.ToInt32(B);
                int c = Convert.ToInt32(C);

                Color Black = Color.Black;
                Pen blackPen = new Pen(Black, 1);

                PointF[] coordinatesFortriangle = new PointF[]
                {
                    new Point(a, b),
                    new Point(b, c),
                    new Point(a, c)
                };
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                g.DrawPolygon(blackPen, coordinatesFortriangle);


            }
            catch 
            {
                MessageBox.Show("Неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Triangle_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
