using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        Graphics Graph;
        SolidBrush MyBrush;
        Pen MyPen;
        int x, y;

        Random random = new Random();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; 
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int width =  Math.Abs(e.X - x); 
            int height = Math.Abs(e.Y - y);
            x = Math.Min(e.X, x);
            y = Math.Min(e.Y, y);

            MyPen.Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            MyPen.Width = random.Next(1, 10);

            Graph.FillEllipse(MyBrush, x, y, width, height);
            Graph.DrawEllipse(MyPen, x, y, width, height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyBrush = new SolidBrush(Color.Yellow); 
            MyPen = new Pen(Color.Red, 3);
        }
    }
}
