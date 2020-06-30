using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TugasOOP.Anak;
using TugasOOP.Induk;

namespace TugasOOP

{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi objek
            KaryawanTetap[] karyawanTetap = new KaryawanTetap[20];
            KaryawanHarian[] karyawanHarian = new KaryawanHarian[20];
            Sales[] sales = new Sales[20];

            List<Karyawan> listKaryawan = new List<Karyawan>();

            int pilih, pilih2;
            int a = 0, b = 0, c = 0;
            do
            {
            awal:

                Console.Title = "Praktikum 9";

                Console.WriteLine("Karyawan");
                Console.WriteLine("==========================");
                Console.WriteLine("Pilih Menu :");
                Console.WriteLine("1. Tambah Data");
                Console.WriteLine("2. Hapus Data");
                Console.WriteLine("3. Tampilkan Data");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("==================================");
                Console.WriteLine();

                Console.Write("Masukan Pilihan : ");
                pilih = Convert.ToInt32(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Tambah Karyawan");
                            Console.WriteLine("==================================");
                            Console.WriteLine("Pilih Karyawan : ");
                            Console.WriteLine("1. Karyawan Tetap ");
                            Console.WriteLine("2. Karyawan Harian");
                            Console.WriteLine("3. Sales");
                            Console.WriteLine("4. Kembali");
                            Console.WriteLine("==================================/n");
                            Console.WriteLine("Masukan Pilihan : ");

                            pilih2 = Convert.ToInt32(Console.ReadLine());

                            switch (pilih2)
                            {
                                //Tambah Karyawan
                                case 1:
                                    //Karyawan Tetap                        
                                    a++;
                                    karyawanTetap[a] = new KaryawanTetap();

                                    Console.Clear();
                                    Console.WriteLine("\nTambah Karyawan Tetap \n ");
                                    Console.Write("NIK          : ");
                                    karyawanTetap[a].Nik = Console.ReadLine();
                                    Console.Write("Nama         : ");
                                    karyawanTetap[a].Nama = Console.ReadLine();
                                    Console.Write("Gaji Bulanan : ");
                                    karyawanTetap[a].GajiBulanan = int.Parse(Console.ReadLine());

                                    //list
                                    listKaryawan.Add(karyawanTetap[a]);
                                    Console.WriteLine("\n");
                                    break;

                                case 2:
                                    //Karyawan Harian
                                    b++;
                                    karyawanHarian[b] = new KaryawanHarian();

                                    Console.Clear();
                                    Console.WriteLine("\nTambah Karyawan Harian \n ");
                                    Console.Write("NIk              : ");
                                    karyawanHarian[b].Nik = Console.ReadLine();
                                    Console.Write("Nama             : ");
                                    karyawanHarian[b].Nama = Console.ReadLine();
                                    Console.Write("Jumlah Jam Kerja : ");
                                    karyawanHarian[b].JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Upah Per Jam     : ");
                                    karyawanHarian[b].UpahPerJam = Convert.ToDouble(Console.ReadLine());

                                    //list
                                    listKaryawan.Add(karyawanHarian[b]);
                                    Console.WriteLine("\n");
                                    break;

                                case 3:
                                    //Sales                                
                                    c++;
                                    sales[c] = new Sales();

                                    Console.Clear();
                                    Console.WriteLine("\nTambah Sales \n ");
                                    Console.Write("NIK              : ");
                                    sales[c].Nik = Console.ReadLine();
                                    Console.Write("Nama             : ");
                                    sales[c].Nama = Console.ReadLine();
                                    Console.Write("Jumlah Penjualan : ");
                                    sales[c].JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Komisi           : ");
                                    sales[c].Komisi = Convert.ToDouble(Console.ReadLine());

                                    //list
                                    listKaryawan.Add(sales[c]);
                                    Console.WriteLine("\n");
                                    break;


                                case 4:
                                    Console.Clear();

                                    goto awal;
                            }

                        }
                        while (pilih2 != 4);
                        Console.Clear();
                        break;

                    //Hapus Karyawan
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Hapus Karyawan");
                        Console.WriteLine("---------------------------------");
                        Console.Write("NIK : ");
                        string nikhapus = Console.ReadLine();

                        if (listKaryawan.Any(n => n.Nik == nikhapus))
                        {
                            listKaryawan.RemoveAll(c => c.Nik == nikhapus);
                            Console.WriteLine("Data karyawan berhasil dihapus\n\n");
                        }
                        else
                        {
                            Console.WriteLine("Data tidak ditemukan\n\n");
                        }

                        break;



                    //Tampil Data Karyawan
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Tampilkan Data");
                        Console.WriteLine("---------------------------------");
                        int nourut = 0;

                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            nourut++;
                            Console.Write("{0}. NIK : {1} | Nama: {2} | Gaji: {3:N0} | ",
                            nourut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                            if (karyawan is KaryawanTetap)
                            {
                                Console.Write("Karyawan Tetap \n");
                            }

                            else if (karyawan is KaryawanHarian)
                            {
                                Console.Write("Karyawan Harian \n");
                            }

                            else if (karyawan is Sales)
                            {
                                Console.Write("Sales \n");
                            }
                        }
                        Console.WriteLine("\n");

                        break;
                    //KELUAR
                    case 4:
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Wrong Input!!");
                        break;

                }

            }
            while (pilih != 4);
            Environment.Exit(0);

        }

    }

}




                   

