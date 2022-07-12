using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RESPONSI2
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        Console.WriteLine("Maaf pilihan anda tidak ada");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
            Console.Write("\nNomor Menu [1..4]: ");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.WriteLine("Tambah Data Penjualan");
            Penjualan jual = new Penjualan();
            Console.WriteLine("");
            Console.Write("Nota : ");
            jual.Nota = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tanggal : ");
            jual.Tanggal = Console.ReadLine();
            Console.Write("Customer : ");
            jual.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K] : ");
            jual.TK = Console.ReadLine();
            Console.Write("Total Nota : ");
            jual.TotalNota = Convert.ToInt32(Console.ReadLine());
            daftarPenjualan.Add(jual);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Data Penjualan");
            Console.WriteLine("");

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int i = 1;
            foreach(Penjualan item in daftarPenjualan){
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
