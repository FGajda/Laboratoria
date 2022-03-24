using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rysowanie
{
    public partial class Form1 : Form
    {
        FunkcjaKwadratowa liniowa = new FunkcjaKwadratowa();
        Bitmap Axis;
        public Form1()
        {
            InitializeComponent();
            Axis = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = Axis;
        }

        private void DrawAxis(PictureBox P)
        {
            Graphics g = Graphics.FromImage(Axis);
            g.Clear(Color.White);
            Pen p = new Pen(Color.Black, 1.0f);
            g.DrawLine(p, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
            g.DrawLine(p, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            PointF P1u = new PointF(pictureBox1.Width / 2, 0);
            PointF P2u = new PointF(pictureBox1.Width / 2 - pictureBox1.Width / 30, 0 + pictureBox1.Height / 15);
            PointF P3u = new PointF(pictureBox1.Width / 2 + pictureBox1.Width / 30, 0 + pictureBox1.Height / 15);
            PointF[] UpArrowPoints = { P1u, P2u, P3u };
            PointF P1r = new PointF(pictureBox1.Width, pictureBox1.Height / 2);
            PointF P2r = new PointF(pictureBox1.Width - pictureBox1.Width / 15, pictureBox1.Height / 2 - pictureBox1.Height / 30);
            PointF P3r = new PointF(pictureBox1.Width - pictureBox1.Width / 15, pictureBox1.Height / 2 + pictureBox1.Height / 30);
            PointF[] RightArrowPoints = { P1r, P2r, P3r };
            SolidBrush Brush = new SolidBrush(Color.Black);
            g.FillPolygon(Brush, UpArrowPoints);
            g.FillPolygon(Brush, RightArrowPoints);
            pictureBox1.Image = Axis;
        }

        private float ScaleX(PictureBox P, float X)
        {
            float OldMin = -10;
            float OldMax = 10;
            float NewX = (X - OldMin) / (OldMax - OldMin) * P.Width;
            return NewX;
        }

        private float ScaleY(PictureBox P, float Y)
        {
            float OldMin = -10;
            float OldMax = 10;
            float NewY = (Y - OldMin) / (OldMax - OldMin) * P.Height;
            return NewY;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawAxis(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Wspolczynniki = textBox2.Text.Split(';');
            liniowa = new FunkcjaKwadratowa(double.Parse(Wspolczynniki[0]), double.Parse(Wspolczynniki[1]));
            textBox1.Text = liniowa.info();
            Graphics g = Graphics.FromImage(Axis);
            g.Clear(Color.White);
            DrawAxis(pictureBox1);
            Pen p2 = new Pen(Color.Red, 2.0f);
            g.DrawLine(p2, ScaleX(pictureBox1, -10), pictureBox1.Height - ScaleY(pictureBox1, (float)liniowa.A * (-10) + (float)liniowa.B), ScaleX(pictureBox1, 10), pictureBox1.Height - ScaleY(pictureBox1, (float)liniowa.A * (10) + (float)liniowa.B));
            pictureBox1.Image = Axis;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] Wspolczynniki = textBox3.Text.Split(';');
            liniowa = new FunkcjaKwadratowa(double.Parse(Wspolczynniki[0]), double.Parse(Wspolczynniki[1]), double.Parse(Wspolczynniki[2]));
            textBox1.Text = liniowa.info2();
            Graphics g = Graphics.FromImage(Axis);
            g.Clear(Color.White);
            DrawAxis(pictureBox1);
            Pen p2 = new Pen(Color.Red, 2.0f);
            double delta = (liniowa.B * liniowa.B) - (4 * liniowa.A * liniowa.C);
            double p = -liniowa.B / (2 * liniowa.A);
            double q = -delta / (4 * liniowa.A);
            ScaleX(pictureBox1, (float)p);
            ScaleY(pictureBox1, (float)q);

            PointF P1 = new PointF(ScaleX(pictureBox1, ScaleX(pictureBox1, (float)p) / 9), ScaleY(pictureBox1, -(pictureBox1.Height + ScaleY(pictureBox1, (float)q))));
            PointF P2 = new PointF(ScaleX(pictureBox1, (float)p), ScaleY(pictureBox1, -(float)q));
            PointF P3 = new PointF(ScaleX(pictureBox1, -ScaleX(pictureBox1, (float)p) / 9), ScaleY(pictureBox1, -(pictureBox1.Height + ScaleY(pictureBox1, (float)q))));
            PointF[] parabola = { P1, P2, P3 };
            g.DrawCurve(p2, parabola);
            //g.DrawLine(p2, ScaleX(pictureBox1, -10), pictureBox1.Height - ScaleY(pictureBox1, (float)liniowa.A * (-10) + (float)liniowa.B), ScaleX(pictureBox1, 10), pictureBox1.Height - ScaleY(pictureBox1, (float)liniowa.A * (10) + (float)liniowa.B));
            pictureBox1.Image = Axis;
        }
    }
}
