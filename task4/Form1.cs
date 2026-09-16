using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        Graphics Graph;
        Pen MyPen;
        int x1, y1, x2, y2;
        int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random random = new Random();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (count == 0)
            {
                x1 = e.X; y1 = e.Y; count = 1;
            }
            else if (count == 1)
            {
                x2 = e.X;
                y2 = e.Y;
                MyPen.Width = random.Next(1, 10);
                Graph.DrawLine(MyPen, x1, y1, x2, y2); 
                count = 2;
            }
            else
            {
                int x3 = e.X;
                int y3 = e.Y;
                Graph.DrawLine(MyPen, x3, y3, x1, y1);
                Graph.DrawLine(MyPen, x3, y3, x2, y2); 
                count = 0;
            }
        }
        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Blue);
        }
    }
}





//namespace task4
//{
//    public partial class Form1 : Form
//    {
//        Graphics Graph;
//        Pen MyPen;
//        int x1, y1, x2, y2, x3, y3;
//        int count = 0;

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        Random random = new Random();
//        private void Form1_MouseClick(object sender, MouseEventArgs e)
//        {
//            if (count == 0)
//            {
//                x1 = e.X; y1 = e.Y; count = 1;
//            }
//            else if (count == 1)
//            {
//                x2 = e.X;
//                y2 = e.Y;
//                MyPen.Width = random.Next(1, 10);
//                Graph.DrawLine(MyPen, x1, y1, x2, y2);
//                count = 2;
//            }
//            else if (count == 2)
//            {
//                x3 = e.X;
//                y3 = e.Y;

//                //Graph.DrawLine(MyPen, x3, y3, x2, y2); 
//                count = 3;
//            }
//            else
//            {
//                int x4 = e.X;
//                int y4 = e.Y;
//                Graph.DrawLine(MyPen, x3, y3, x4, y4);
//                if (Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2)) <= Math.Sqrt(Math.Pow(x2 - x4, 2) + Math.Pow(y2 - y4, 2)))
//                {
//                    Graph.DrawLine(MyPen, x1, y1, x4, y4);
//                    Graph.DrawLine(MyPen, x2, y2, x3, y3);
//                }
//                else
//                {
//                    Graph.DrawLine(MyPen, x2, y2, x4, y4);
//                    Graph.DrawLine(MyPen, x1, y1, x3, y3);
//                }
//                count = 0;
//            }
//        }
//        public Form1()
//        {
//            InitializeComponent();
//            Graph = CreateGraphics();
//            MyPen = new Pen(Color.Blue);
//        }
//    }
//}