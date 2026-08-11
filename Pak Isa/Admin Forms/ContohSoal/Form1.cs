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
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            // Inisialisasi komponen-komponen yang digunakan, agar bisa dirender saat dimulai
            InitializeComponent();
        }

        // Saat tombol "Login" ditekan, maka:
        private void tombolLogin_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman Form3Dashboard
            Form3Dashboard dashboard = new Form3Dashboard();

            // Sembunyikan halaman saat ini (Form1)
            this.Hide();

            // Tampilkan instansi halaman Form3Dashboard
            dashboard.Show();
        }

        // Saat teks "Daftar Sekarang" ditekan, maka:
        private void teksDaftarSekarang_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman register (Form2Register)
            Form2Register register = new Form2Register();

            // Sembunyikan halaman saat ini (Form1)
            this.Hide();

            // Tampilkan instansi halaman Form2Register
            register.Show();
        }
    }
}
