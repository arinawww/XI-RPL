using System;

namespace Calculator
{
    internal class Zodiak
    {
        public static void Menu()
        {
            int tanggal, bulan;

            Console.Clear();
            Console.WriteLine("===== CEK ZODIAK =====");

            Console.Write("Masukkan Tanggal : ");
            tanggal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Bulan : ");
            bulan = Convert.ToInt32(Console.ReadLine());

            if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
                Console.WriteLine("Zodiak Anda : Aries");
            else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
                Console.WriteLine("Zodiak Anda : Taurus");
            else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
                Console.WriteLine("Zodiak Anda : Gemini");
            else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
                Console.WriteLine("Zodiak Anda : Cancer");
            else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
                Console.WriteLine("Zodiak Anda : Leo");
            else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
                Console.WriteLine("Zodiak Anda : Virgo");
            else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
                Console.WriteLine("Zodiak Anda : Libra");
            else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
                Console.WriteLine("Zodiak Anda : Scorpio");
            else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
                Console.WriteLine("Zodiak Anda : Sagittarius");
            else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
                Console.WriteLine("Zodiak Anda : Capricorn");
            else if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
                Console.WriteLine("Zodiak Anda : Aquarius");
            else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
                Console.WriteLine("Zodiak Anda : Pisces");
            else
                Console.WriteLine("Tanggal atau bulan tidak valid.");
        }
    }
}