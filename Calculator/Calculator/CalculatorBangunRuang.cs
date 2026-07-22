using System;

namespace Calculator
{
    internal class CalculatorBangunRuang
    {
        public static void Menu()
        {
            int pilih;
            double sisi, panjang, lebar, tinggi, jari, volume;

            Console.Clear();
            Console.WriteLine("===== BANGUN RUANG =====");
            Console.WriteLine("1. Kubus");
            Console.WriteLine("2. Balok");
            Console.WriteLine("3. Tabung");
            Console.WriteLine("4. Bola");
            Console.Write("Pilih Menu : ");

            pilih = Convert.ToInt32(Console.ReadLine());

            if (pilih == 1)
            {
                Console.Write("Masukkan Sisi : ");
                sisi = Convert.ToDouble(Console.ReadLine());

                volume = sisi * sisi * sisi;
                Console.WriteLine("Volume Kubus = " + volume);
            }
            else if (pilih == 2)
            {
                Console.Write("Masukkan Panjang : ");
                panjang = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Lebar : ");
                lebar = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Tinggi : ");
                tinggi = Convert.ToDouble(Console.ReadLine());

                volume = panjang * lebar * tinggi;
                Console.WriteLine("Volume Balok = " + volume);
            }
            else if (pilih == 3)
            {
                Console.Write("Masukkan Jari-jari : ");
                jari = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Tinggi : ");
                tinggi = Convert.ToDouble(Console.ReadLine());

                volume = 3.14 * jari * jari * tinggi;
                Console.WriteLine("Volume Tabung = " + volume);
            }
            else if (pilih == 4)
            {
                Console.Write("Masukkan Jari-jari : ");
                jari = Convert.ToDouble(Console.ReadLine());

                volume = 4.0 / 3.0 * 3.14 * jari * jari * jari;
                Console.WriteLine("Volume Bola = " + volume);
            }
            else
            {
                Console.WriteLine("Menu tidak tersedia.");
            }
        }
    }
}