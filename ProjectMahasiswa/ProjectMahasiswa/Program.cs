using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
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
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahsiswa");
            Console.WriteLine("3. Keluar");
            Console.WriteLine();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Mahasiswa mhs = new Mahasiswa();
            Console.Clear();
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.WriteLine();

            Console.Write("Nim : ");
            string nim = Convert.ToString(Console.ReadLine());
            mhs.Nim = nim;

            Console.Write("Nama : ");
            string name = Convert.ToString(Console.ReadLine());
            mhs.Name = name;

            Console.Write("Jenis Kelamin [L/P] : ");
            char gender = Convert.ToChar(Console.ReadLine());
            if(gender=='L')
            {
                mhs.Gender = "Laki-laki";
            }
            else
            {
                mhs.Gender = "Perempuan";
            }

            Console.Write("IPK : ");
            double ipk = Convert.ToDouble(Console.ReadLine());
            mhs.Ipk = ipk;

            daftarMahasiswa.Add(mhs);
            Console.WriteLine();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Data Mahasiswa");
            Console.WriteLine();

            int i = 1;
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {               
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", i, mhs.Nim, mhs.Name, mhs.Gender, mhs.Ipk);
                i++;
            }
            Console.WriteLine();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
