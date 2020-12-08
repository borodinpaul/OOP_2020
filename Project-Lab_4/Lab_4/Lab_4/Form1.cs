using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle C = new Circle(50, 100, 50);
            Pen pen = new Pen(Brushes.Red);
            Graphics circle = pictureBox1.CreateGraphics();
            circle.DrawEllipse(pen, C.CenterX, C.CenterY, C.Radius * 2, C.Radius * 2);
            circle.DrawString($"{C.Show()}\nПлоща кола: {C.Area()}", new Font("Arial", 10), Brushes.Green, 2, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trapezoid T = new Trapezoid(50, 150, 100, 150, 180, 200, 25, 200);
            Pen pen = new Pen(Brushes.Blue);
            Graphics trapezoid = pictureBox1.CreateGraphics();
            trapezoid.DrawLine(pen, T.CenterX, T.CenterY, T.RightTopX, T.RightTopY);
            trapezoid.DrawLine(pen, T.RightTopX, T.RightTopY, T.RightBottomX, T.RightBottomY);
            trapezoid.DrawLine(pen, T.RightBottomX, T.RightBottomY, T.LeftBottomX, T.LeftBottomY);
            trapezoid.DrawLine(pen, T.LeftBottomX, T.LeftBottomY, T.CenterX, T.CenterY);
            trapezoid.DrawString($"{T.Show()}\nПлоща трапеції: {T.Area()}", new Font("Arial", 10), Brushes.Green, 2, 220);
        }
    }
}
