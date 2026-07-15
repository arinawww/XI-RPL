// method / fungsi sederhana

// pada materi ini kita akan mempleajari:
// 1. method
// 2. parameter
// 3. return value



// 1. method
// adalah kumpulan code yang digunakan untuk menjalankan tugas tertentu
// dapat membantu program menjadi:
// - lebih rapih
// - lebih terstruktur
// - dan dapat digunakan kembali (reuse)

//      void karena menthod tidak mengembalikan nilai (tanpa return value)
static void Salam() // menthod bernama salam
{
    Console.WriteLine("Hello Word"); // method memiliki tugas untuk menampilkan "Hello Word"
}

// memanggil method tanpa return value dan tanpa parameter
Salam ();


// 2.Method tanpa parameter 
// parameter digunakan untuk mengirim data ke method

static void Sapa(string nama) // parameter bertipe string
{
    Console.WriteLine("Halo " + nama); // variabel parameter dimasukkan ke dalam method
}

// memanggil method dengan parameter sesuai dengan tipe parameter pada method yang kita buat sebelumnya
Sapa("Budi");



// 3. Method dengan return value
// method juga dapat mengembalikan nilai (return value)

// int dan bukan void karena method memiliki return value

static int Tambah(int a, int b) // method akan menghasilkan nilai bertipe int
{
    return a + b; // return digunakan untuk mengembalikan hasil
}


// memanggil method dengan return value
Console.WriteLine(Tambah(5, 7));

// method digunakan untuk menjalankan tugas tertentu
// parameter digunakan untuk menerima data
//  return digunkan untuk mengembalikan nilai