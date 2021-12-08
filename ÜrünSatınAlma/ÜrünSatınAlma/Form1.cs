using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜrünSatınAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secim = comboBox1.SelectedItem.ToString();

            switch (secim)
            {
                case "Kazak":
                    textBox1.Text = "15";
                    pictureBox1.ImageLocation = "C:\\Users\\olcy\\Desktop\\Kazak.jpg";
                    break;
                case "T-Shirt":
                    textBox1.Text = "20";
                    pictureBox1.ImageLocation = "C:\\Users\\olcy\\Desktop\\T-Shirt.jpg";
                    break;
                case "Pantolon":
                    textBox1.Text = "40";
                    pictureBox1.ImageLocation = "C:\\Users\\olcy\\Desktop\\Pantolon.jpg";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ufiyat = Convert.ToInt32(textBox1.Text); ;
            int oyontemi;
            int adet = Convert.ToInt32(textBox2.Text); ;
            int fiyat;
            int hesap;
            if (radioButton1.Checked)
            {
                oyontemi = (ufiyat * 10) / 100;
                fiyat = ufiyat + oyontemi;
                hesap = fiyat + adet;
                textBox3.Text = hesap.ToString();
                listBox1.Items.Add(comboBox1.Text+" "+ hesap.ToString() + "TL");
            }
            if (radioButton2.Checked)
            {
                oyontemi = (ufiyat * 10) / 100;
                fiyat = ufiyat - oyontemi;
                hesap = fiyat + adet;
                textBox3.Text = hesap.ToString();
                listBox1.Items.Add(comboBox1.Text + " " + hesap.ToString() + "TL");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
