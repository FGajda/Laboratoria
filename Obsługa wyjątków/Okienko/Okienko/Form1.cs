using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Okienko
{
    
    public partial class Form1 : Form
    {
        Konto K = new Konto("Jan", "Kowal", 1000, 1111);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nazwa.Text == K.Wlasciciel.Nazwisko && PIN.Text == K.PIN.ToString())
            {
                Form2 f2 = new Form2(K);
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Nieprawidłowy PIN i/lub login");
        }

        private void Nazwa_TextChanged(object sender, EventArgs e)
        {

        }

        private void PIN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
