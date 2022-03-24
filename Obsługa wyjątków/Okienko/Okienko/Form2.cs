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
    public partial class Form2 : Form
    {
        Konto K = new Konto();
        public Form2(Konto A)
        {
            InitializeComponent();
            K = A;
        }

        private void Saldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void wplata_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(K.wplata(int.Parse(wplatatext.Text)));
                Saldo.Text = K.Saldo.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void wyplatatext_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void wyplata_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(K.wyplata(int.Parse(wyplatatext.Text), K.PIN));
                Saldo.Text = K.Saldo.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(K.info(K.PIN));
                Saldo.Text = K.Saldo.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void PinZmien_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(K.zmianaPIN(K.PIN,int.Parse(zmienPINtext.Text)));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        
    }
}
