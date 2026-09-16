using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        Graphics Graph;
        Pen MyPen;
        int x, y;
        int xStart, yStart;
        bool draw = false;
        Random random = new Random();
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!draw)
            {
                draw = true;
                xStart = e.X;
                yStart = e.Y;
                x = e.X;
                y = e.Y;
                MyPen.Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }
            else
            {
                Graph.DrawLine(MyPen, x, y, e.X, e.Y);
                Graph.DrawLine(MyPen, e.X, e.Y, xStart, yStart);
                draw = false;
                x = e.X;
                y = e.Y;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graph.DrawLine(MyPen, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Blue, 2);
        }
    }
}

//namespace task5
//{
//    public partial class Form1 : Form
//    {
//        Graphics Graph;
//        Pen MyPen;
//        SolidBrush MyBrush;
//        int x, y;
//        int s = 9;
//        int xStart, yStart;
//        bool draw = false;
//        Random random = new Random();
//        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
//        {
//            if (!draw)
//            {
//                draw = true;
//                xStart = e.X;
//                yStart = e.Y;
//                x = e.X;
//                y = e.Y;
//                int r = random.Next(256);
//                int g = random.Next(256);
//                int b = random.Next(256);
//                MyPen.Color = Color.FromArgb(r, g, b);
//                MyBrush.Color = Color.FromArgb(r, g, b);
//                Graph.DrawEllipse(MyPen, x - s / 2, y - s / 2, s, s);
//                Graph.FillEllipse(MyBrush, x - s / 2, y - s / 2, s, s);
//            }
//            else
//            {
//                Graph.DrawLine(MyPen, x, y, e.X, e.Y);
//                Graph.DrawLine(MyPen, e.X, e.Y, xStart, yStart);
//                draw = false;
//                x = e.X;
//                y = e.Y;
//                Graph.DrawEllipse(MyPen, x - s / 2, y - s / 2, s, s);
//                Graph.FillEllipse(MyBrush, x - s / 2, y - s / 2, s, s);
//            }
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void Form1_MouseDown(object sender, MouseEventArgs e)
//        {
//            if (draw)
//            {
//                Graph.DrawLine(MyPen, x, y, e.X, e.Y);
//                x = e.X;
//                y = e.Y;
//                Graph.DrawEllipse(MyPen, x - s / 2, y - s / 2, s, s);
//                Graph.FillEllipse(MyBrush, x - s / 2, y - s / 2, s, s);
//            }
//        }

//        public Form1()
//        {
//            InitializeComponent();
//            Graph = CreateGraphics();
//            MyBrush = new SolidBrush(Color.Yellow);
//            MyPen = new Pen(Color.Blue, 2);
//        }
//    }
//}