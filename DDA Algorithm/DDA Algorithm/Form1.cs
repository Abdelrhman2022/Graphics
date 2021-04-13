using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDA_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        void lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            var sbrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            double xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            g.FillRectangle(sbrush, (float)Math.Round(x), (float)Math.Round(y), 2, 2);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                g.FillRectangle(sbrush, (float)Math.Round(x), (float)Math.Round(y), 2, 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lineDDA(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter Intger Number", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Invalidate();
        }
    }
}
