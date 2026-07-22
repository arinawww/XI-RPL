using System;

namespace Calculator
{
    internal class CalculatorBangunDatar
    {
        public static void Menu()
        {
            int pilih;
            double sisi, panjang, lebar, alas, tinggi, jari, luas;

            Console.Clear();
            Console.WriteLine("===== BANGUN DATAR =====");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Lingkaran");
            Console.Write("Pilih Menu : ");

            pilih = Convert.ToInt32(Console.ReadLine());

            if (pilih == 1)
            {
                Console.Write("Masukkan Sisi : ");
                sisi = Convert.ToDouble(Console.ReadLine());

                luas = sisi * sisi;
                Console.WriteLine("Luas Persegi = " + luas);
            }
            else if (pilih == 2)
            {
                Console.Write("Masukkan Panjang : ");
                panjang = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Lebar : ");
                lebar = Convert.ToDouble(Console.ReadLine());

                luas = panjang * lebar;
                Console.WriteLine("Luas Persegi Panjang = " + luas);
            }
            else if (pilih == 3)
            {
                Console.Write("Masukkan Alas : ");
                alas = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Tinggi : ");
                tinggi = Convert.ToDouble(Console.ReadLine());

                luas = 0.5 * alas * tinggi;
                Console.WriteLine("Luas Segitiga = " + luas);
            }
            else if (pilih == 4)
            {
                Console.Write("Masukkan Jari-jari : ");
                jari = Convert.ToDouble(Console.ReadLine());

                luas = 3.14 * jari * jari;
                Console.WriteLine("Luas Lingkaran = " + luas);
            }
            else
            {
                Console.WriteLine("Menu tidak tersedia.");
            }
        }
    }
}