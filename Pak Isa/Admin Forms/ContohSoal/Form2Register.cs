using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohSoal
{
    public partial class Form2Register : Form
    {
        public Form2Register()
        {
            // Inisialisasi komponen-komponen pada halaman Form2Register
            InitializeComponent();
        }

        // Apabila tombol daftar diklik:
        private void tombolDaftar_Click(object sender, EventArgs e)
        {
            // Tampilkan kotak pesan dengan kalimat: "Berhasil Daftar, Silakan Login!"
            MessageBox.Show("Berhasil Daftar, Silakan Login!");
        }

        // Apabila teks login diklik:
        private void teksLogin_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1Login)
            Form1Login login = new Form1Login();

            // Tutup halaman saat ini (Form2Register)
            this.Close();

            // Tampilkan instansi halaman login (Form1Login)
            login.Show();
        }
    }
}
