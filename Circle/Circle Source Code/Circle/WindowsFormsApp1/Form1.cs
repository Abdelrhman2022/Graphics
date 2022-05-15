using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void circle(int xCenter, int yCenter, int radius)
        {

            // var aBrush = Brushes.Black;
            SolidBrush mySolidBrush = new SolidBrush(Color.Aquamarine);
            var g = panel1.CreateGraphics();

            int x = radius;
            int y = 0;
            int err = 0;

            while (x >= y)
            {
                g.FillRectangle(mySolidBrush, xCenter + x, yCenter + y, 3, 3);
                g.FillRectangle(mySolidBrush, xCenter + y, yCenter + x, 3, 3);
                g.FillRectangle(mySolidBrush, xCenter - y, yCenter + x, 3, 3);
                g.FillRectangle(mySolidBrush, xCenter - x, yCenter + y, 3, 3);
                g.FillRectangle(mySolidBrush, xCenter - x, yCenter - y, 3, 3);
                g.FillRectangle(mySolidBrush, xCenter - y, yCenter - x, 3, 3);
                g.FillRectangle(mySolidBrush, xCenter + y, yCenter - x, 3, 3);
                g.FillRectangle(mySolidBrush, xCenter + x, yCenter - y, 3, 3);

                if (err <= 0)
                {
                    y += 1;
                    err += 2 * y + 1;
                }

                if (err > 0)
                {
                    x -= 1;
                    err -= 2 * x + 1;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xTxtBox.Text);
            int y = int.Parse(yTxtBox.Text);
            int radius = int.Parse(rTxtBox.Text);

            circle(x, y, radius);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.panel1.Invalidate();
        }
    }
}
