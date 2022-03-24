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
        int[,] Tab = ClassLibrary3.Class1.Tab2D(10, 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void Generuj_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Tab.GetLength(0); i++)
            {
                for (int j = 0; j < Tab.GetLength(1); j++)
                {
                    textBox1.AppendText(Tab[i, j].ToString());
                    textBox1.AppendText("\t");
                } textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
