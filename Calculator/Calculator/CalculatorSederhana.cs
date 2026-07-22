using System;

namespace Calculator
{
    internal class CalculatorSederhana
    {
        public static void Menu()
        {
            int pilih;
            double angka1, angka2, hasil;

            Console.Clear();
            Console.WriteLine("===== KALKULATOR =====");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Pilih Menu : ");

            pilih = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Angka Pertama : ");
            angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Angka Kedua : ");
            angka2 = Convert.ToDouble(Console.ReadLine());

            if (pilih == 1)
            {
                hasil = angka1 + angka2;
                Console.WriteLine("Hasil = " + hasil);
            }
            else if (pilih == 2)
            {
                hasil = angka1 - angka2;
                Console.WriteLine("Hasil = " + hasil);
            }
            else if (pilih == 3)
            {
                hasil = angka1 * angka2;
                Console.WriteLine("Hasil = " + hasil);
            }
            else if (pilih == 4)
            {
                if (angka2 == 0)
                {
                    Console.WriteLine("Tidak bisa dibagi nol.");
                }
                else
                {
                    hasil = angka1 / angka2;
                    Console.WriteLine("Hasil = " + hasil);
                }
            }
            else
            {
                Console.WriteLine("Menu tidak tersedia.");
            }
        }
    }
}