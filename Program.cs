using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penjualan
{
    class Program
    {
        static List<Penjualan> daftarProduk = new List<Penjualan>();
        static Penjualan Penjual = new Penjualan();

        static void Main(string[] args)
        {
            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..3]: ");
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
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi\n");
            Console.WriteLine("1. Tambah produk");
            Console.WriteLine("2. Tampilkan produk");
            Console.WriteLine("3. Keluar\n");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Penjual = new Penjualan();
            Console.WriteLine("Tambah data produk");
            Console.WriteLine();
            Console.Write("Nota       : ");
            Penjual.Nota = Console.ReadLine();
            Console.Write("Tanggal    : ");
            Penjual.Tanggal = Console.ReadLine();
            Console.Write("Customer   : ");
            Penjual.Nama = Console.ReadLine();
            Console.Write("Jenis (T/K): ");
            Penjual.Gender = Console.ReadLine() == "T" ? "Tunai" : "Kredit";
            Console.Write("TotalNota  : ");
            Penjual.Total = Convert.ToInt32(Console.ReadLine());
            daftarProduk.Add(Penjual);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine("Data Produk\n");

            foreach (Penjualan objProd in daftarProduk)
            {

                Console.WriteLine("{0}.{1},{2},{3},{4}", objProd.Nota, objProd.Tanggal, objProd.Nama, objProd.Gender, objProd.Total);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}