namespace KalkulatorSederhana;
class Program
{
    static void Main(string[] args)
    {
        // Meminta pengguna untuk memasukkan dua bilangan
        Console.Write("Masukkan bilangan pertama: ");
        if (!double.TryParse(Console.ReadLine(), out double bilangan1))
        {
            Console.WriteLine("Input tidak valid. Program berakhir.");
            return;
        }

        Console.Write("Masukkan bilangan kedua: ");
        if (!double.TryParse(Console.ReadLine(), out double bilangan2))
        {
            Console.WriteLine("Input tidak valid. Program berakhir.");
            return;
        }
        // Memilih operasi matematika
        Console.WriteLine("\nPilih operasi matematika:");
        Console.WriteLine("1. Penjumlahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");

        Console.Write("Masukkan nomor operasi (1-4): ");
        if (!int.TryParse(Console.ReadLine(), out int pilihanOperasi) || pilihanOperasi < 1 || pilihanOperasi > 4)
        {
            Console.WriteLine("Pilihan operasi tidak valid. Program berakhir.");
            return;
        }

        // Melakukan operasi matematika sesuai pilihan pengguna
        double hasil = 0;
        switch (pilihanOperasi)
        {
            case 1:
                hasil = bilangan1 + bilangan2;
                break;
            case 2:
                hasil = bilangan1 - bilangan2;
                break;
            case 3:
                hasil = bilangan1 * bilangan2;
                break;
            case 4:
                if (bilangan2 != 0)
                {
                    hasil = bilangan1 / bilangan2;
                }
                else
                {
                    Console.WriteLine("Tidak dapat melakukan pembagian dengan nol. Program berakhir.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Pilihan operasi tidak valid. Program berakhir.");
                return;
        }

        // Menampilkan hasil operasi matematika
        Console.WriteLine($"\nHasil dari operasi matematika: {hasil}");
        Console.ReadKey(); // Menahan tampilan konsol agar tidak langsung tertutup

    }
}
