// Materi Percabangan

// pada kesempatan kali ini kita akan mempelajari percabangan: IF, Else IF, dan Switch


// percabangan digunakan untuk mengambil keputusan pada program 
// program dapat menjalankan perintah berbeda tergantung kondisi tertentu

// IF
int umur = 15;

//if (umur >= 17) // IF digunakan untuk mengecek kondisi,
//                // kondisi akan menghasilkan true dan false
//{
//    Console.WriteLine("Boleh membuat KTP"); // ini output jika hasilnya true
//}



// ELSE 

if (umur >= 17) // IF digunakan untuk mengecek kondisi,
                // kondisi akan menghasilkan true dan false
{
    Console.WriteLine("Boleh membuat KTP"); // ini output jika hasilnya true
}
else // else dijalankan jika kondisi false
     // else digunakan sebagai alternatif ketika kondisi if tidak terpenuhi 
{
    Console.WriteLine("Belum boleh membuat KTP");
}

// ELSE IF 

int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Grade A");

} else if (nilai >= 75) // Else IF digunakan untuk menambahkan kondisi lain
                        // Else IF memungkingkan program memriksa beberapa kondisi berbeda
{
    Console.WriteLine("Grade B");


} else 
{

    Console.WriteLine("Grade C");

}


// Switch 

//digunakan untuk memilih kondisi berdasarkan nilai tertentu

string hari = "Senin";

switch (hari) // switch digunakan untuk memeriksa nilai variabel

{
    case "Senin"; // case adalah pilihan kondisi
        Console.WriteLine("Hari Pertama");
        break; // break digunakan untuk menghentikan switch

    case "Minggu";
        Console.WriteLine("Hari Ketujuh");
        break;

    default: // default dijalanan jika tidak ada kondisi yang cocok (mirip seperti false di Else IF)
        Console.WriteLine("Hari Lain");
        break;

}

// dengan ini kita sudah memplejarari percabangan IF, Else, Else IF, serta Switch