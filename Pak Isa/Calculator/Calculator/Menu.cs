using System;

namespace Calculator
{
    internal class Menu
    {
        public static void MenuUtama()
        {
            int pilih;

            do
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("          MENU UTAMA");
                Console.WriteLine("================================");
                Console.WriteLine("1. Kalkulator");
                Console.WriteLine("2. Bangun Datar");
                Console.WriteLine("3. Bangun Ruang");
                Console.WriteLine("4. Zodiak");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih Menu : ");

                pilih = Convert.ToInt32(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        CalculatorSederhana.Menu();
                        break;

                    case 2:
                        CalculatorBangunDatar.Menu();
                        break;

                    case 3:
                        CalculatorBangunRuang.Menu();
                        break;

                    case 4:
                        Zodiak.Menu();
                        break;

                    case 5:
                        Console.WriteLine("Terima kasih.");
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak tersedia.");
                        break;
                }

                if (pilih != 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Tekan Enter untuk kembali...");
                    Console.ReadLine();
                }

            } while (pilih != 5);
        }
    }
}