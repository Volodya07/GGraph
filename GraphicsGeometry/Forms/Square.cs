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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string a = textBox1.Text;
                float S;
                float A = float.Parse(a);

                float d = (float)(A * Math.Sqrt(2));

                S = (float)Math.Pow(A, 2);

                int Perimetr = (int)(A * 4); 

                label2.Text = "Диагональ квадрата равна " + d;
                label3.Text = "Площадь квадрата равна " + S;
                label4.Text = "Периметр квадрата равен" + Perimetr;
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
                string a = textBox1.Text;
                int A = int.Parse(a);

                Pen myPen = new Pen(Color.Black, 1);
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                g.DrawRectangle(myPen, 500, 100, A, A);
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Square_Load(object sender, EventArgs e)
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
