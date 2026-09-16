using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        Graphics Graph; 
        Pen MyPen;
        public Form1()
        {
            InitializeComponent();
            MyPen = new Pen(Color.White,2);
            Graph = CreateGraphics();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int r = 8;
            for (int i = 0; i < 8; i++)
            {
                double angle = i * Math.PI / 4;
                int x2 = e.X + (int)(r * Math.Cos(angle));
                int y2 = e.Y + (int)(r * Math.Sin(angle));
                Graph.DrawLine(MyPen, e.X, e.Y, x2, y2);
            }
        }
    }
}
