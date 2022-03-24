using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            int n1 ;
            int n2 ;
            int[,] tab,tab2;
        private void Drukowanie(TextBox TextBox, int n, int n2, int[,] tab)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    TextBox.AppendText(tab[i, j].ToString() + '\t');
                } TextBox.AppendText(Environment.NewLine);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] n = textBox1.Text.Split(',');
            int n1 = int.Parse(n[0]);
            int n2 = int.Parse(n[1]);
            int[,] tab = Tablice.Tablica.GenerowanieDwa(n1, n2);
            if (n1 != 0 && n2 != 0)
            {
                Drukowanie(textBox2, n1, n2, tab);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] n = textBox5.Text.Split(',');
            int n1 = int.Parse(n[0]);
            int n2 = int.Parse(n[1]);
            int[,] tab2 = Tablice.Tablica.GenerowanieDwa(n1, n2);
            if (n1 != 0 && n2 != 0)
            {
                Drukowanie(textBox4, n1, n2, tab2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Tablice.Tablica.Sortowanie(ref tab, n1, n2);
            Drukowanie(textBox3, n1, n2, tab);
        }
    }
}
