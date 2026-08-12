using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NilaiSiswa
{
    public partial class NilaiSiswa : Form
    {
        public NilaiSiswa()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCekNilai_Click(object sender, EventArgs e)
        {
            int nilai;

            if (int.TryParse(txtNilai.Text, out nilai))
            {
                if (nilai == 0)
                {
                    txtPredikat.Text = "Nilai : 0\r\nPredikat : Tidak ada nilai";
                }
                else if (nilai >= 90 && nilai <= 100)
                {
                    txtPredikat.Text = "Nilai : " + nilai + "\r\nPredikat : A";
                }
                else if (nilai >= 80)
                {
                    txtPredikat.Text = "Nilai : " + nilai + "\r\nPredikat : B";
                }
                else if (nilai >= 70)
                {
                    txtPredikat.Text = "Nilai : " + nilai + "\r\nPredikat : C";
                }
                else if (nilai >= 60)
                {
                    txtPredikat.Text = "Nilai : " + nilai + "\r\nPredikat : D";
                }
                else if (nilai >= 1)
                {
                    txtPredikat.Text = "Nilai : " + nilai + "\r\nPredikat : E";
                }
                else
                {
                    txtPredikat.Text = "Nilai tidak valid";
                }
            }
            else
            {
                txtPredikat.Text = "Masukkan angka terlebih dahulu";
            }
        }
    }
}