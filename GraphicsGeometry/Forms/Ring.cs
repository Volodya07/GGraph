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
    public partial class Ring : Form
    {
        public Ring()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string R = textBox1.Text;
                string r = textBox2.Text;

                int Radius = Convert.ToInt32(R);
                int radius = Convert.ToInt32(r);

                double S = Math.PI * (Math.Pow(Radius, 2) - Math.Pow(radius, 2));

                label2.Text = "Площадь кольца равна" + S;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string R = textBox1.Text;
                string r = textBox2.Text;

                int Radius = Convert.ToInt32(R);
                int radius = Convert.ToInt32(r);

                Pen myPen = new Pen(Color.Black, 1);
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                g.DrawEllipse(myPen, 940, 440, Radius, Radius);
                g.DrawEllipse(myPen, 945, 445, radius, radius);
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ring_Load(object sender, EventArgs e)
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
