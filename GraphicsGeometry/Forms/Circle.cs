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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
            string r = textBox1.Text;
            float S;
            float C;

            float R = float.Parse(r);

            S = (float)(Math.PI + Math.Pow(R, 2));

            C = (float)(2 * Math.PI * R);

            label2.Text = "Плошадь круга равна: " + S;
            label3.Text = "Длина круга равна: " + C; 
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
                string r = textBox1.Text;

                int R = Convert.ToInt32(r);

                Pen myPen = new Pen(Color.Black, 1);
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                g.DrawEllipse(myPen, 500, 100, R, R);
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

        private void Circle_Load(object sender, EventArgs e)
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
