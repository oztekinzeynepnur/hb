using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Tabanlama_ders_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10;   // Yüzde 10 indirim
            label3.Text = indirimliFiyat.ToString();

            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10;
            label5.Text = (etiketFiyati - indirimliFiyat * 0.10).ToString();

            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10;
            label7.Text = (button1.Text);
 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25;   // Yüzde 25 indirim
            label3.Text = indirimliFiyat.ToString();

            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25;
            label5.Text = (etiketFiyati - indirimliFiyat * 0.25).ToString();

            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10;
            label7.Text = (button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50;   // Yüzde 50 indirim
            label3.Text = indirimliFiyat.ToString();

            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50;
            label5.Text = (etiketFiyati - indirimliFiyat * 0.50).ToString();

            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50;
            label7.Text = (button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75;   // Yüzde 75 indirim
            label3.Text = indirimliFiyat.ToString();

            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75;
            label5.Text = (etiketFiyati - indirimliFiyat * 0.75).ToString();

            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75;
            label7.Text = (button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double etiketFiyati;
            double indirimliFiyat;
            double indirimOranı;

            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimOranı = Convert.ToDouble(comboBox1.SelectedItem.ToString());

            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50;   // Yüzde 50 indirim

            label9.Text = indirimliFiyat.ToString();
            label11.Text = (etiketFiyati - indirimliFiyat * 0.10).ToString();
            label13.Text = indirimOranı.ToString();
        }
    }
}
