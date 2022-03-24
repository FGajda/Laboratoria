using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(a.Next(100));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
