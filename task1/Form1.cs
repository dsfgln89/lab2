using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace task1
{
    public partial class Form1 : Form
    {

        int x, y;
        Graphics Graph;
        Pen MyPen;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            Graph = CreateGraphics();
            MyPen = new Pen(Color.Blue);
            float[] dashValues = { 5, 4 };
            MyPen.DashPattern = dashValues;


        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MyPen.Color = Color.FromArgb(
                rand.Next(256),
                rand.Next(256),
                rand.Next(256));


            MyPen.Width = rand.Next(1, 10);
        
            Graph.DrawLine(MyPen, x, y, e.X, e.Y);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}
