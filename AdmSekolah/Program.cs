using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmSekolah
{
    //Membuat class AdministrasiSekolah
    public class AdministrasiSekolah
    {
        //Mendeklarasikan variabel untuk menyimpan kalimat
        int NIS; 
        string Admin, Nama_Siswa, Jenis_Kelamin, Alamat, Kelas, Nama_WaliKelas;

        public void DataSiswa2()
        {
            //Mendefinisikan bagian array untuk mengelola data
            int[] arrayA; //untuk menginput jumlah siswa
            string[] arrayB; //untuk menginput nama siswa
            string[] arrayC; //untuk menginput jenis kelamin
            string[] arrayD; //untuk menginput alamat
            string[] arrayE; //untuk menginput kelas
            string[] arrayF; //untuk menginput wali kelas
            int jumlah;
            Console.WriteLine("--------Data Siswa Neo Highschool---------");
            Console.WriteLine("\nMasukkan Jumlah Siswa: ");
            jumlah = Convert.ToInt32(Console.ReadLine());

            arrayA = new int[jumlah];
            arrayB = new string[jumlah];
            arrayC = new string[jumlah];
            arrayD = new string[jumlah];
            arrayE = new string[jumlah];
            arrayF = new string[jumlah];

            //Menginput dengan menggunakan for pada bagian array
            for (int i = 0; i < jumlah; i++)
            {
                Console.Write("Nomor Induk Siswa (NIS) : ");
                arrayA[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nama Siswa: ");
                arrayB[i] = Convert.ToString(Console.ReadLine());

                Console.Write("Jenis Kelamin : ");
                arrayC[i] = Convert.ToString(Console.ReadLine());

                Console.Write("Alamat : ");
                arrayD[i] = Convert.ToString(Console.ReadLine());

                Console.Write("Kelas : ");
                arrayE[i] = Convert.ToString(Console.ReadLine());

                Console.Write("Wali Kelas : ");
                arrayF[i] = Convert.ToString(Console.ReadLine());

            }
            //Perintah untuk menampilkan data siswa
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("--------Data Siswa Neo Highschool---------");
            Console.WriteLine("------------------------------------------");
            Console.Write("Nomor Induk SeKolah (NIS)\t");
            Console.Write("Nama\t");
            Console.Write("Jenis Kelamin\t");
            Console.Write("Alamat\t");
            Console.Write("Kelas\t");
            Console.Write("Wali Kelas\t");

            //Melakukan pengulangan pada bagian array
            for (int i = 0; i < jumlah; i++)
            {
                Console.Write("\n");
                Console.Write("{0}\t", arrayA[i]);
                Console.Write("{0}\t", arrayB[i]);
                Console.Write("{0}\t", arrayC[i]);
                Console.Write("{0}\t", arrayD[i]);
                Console.Write("{0}\t", arrayE[i]);
                Console.Write("{0}\t", arrayF[i]);
            }
        }
    }
    //Membuat class program untuk menjalankan program yang dibuat
    class Program
        {
            static void Main(string[] args)
            {
                AdministrasiSekolah AS = new AdministrasiSekolah();

                int pilih;
                string ulang;
                ulang = "Yes";
                while (ulang == "Yes")
                {
                    //Perintah untuk menampilkan halaman utama
                    Console.WriteLine("Selamat datang di Data Administrasi Neo Highschool, ketik 1 untuk melanjutkan");

                    pilih = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                //Menggunakan switch case untuk memastikan persamaan antara sebuah nilai
                //dengan nilai yang ada pada case dalam switch 
                    switch (pilih)
                    {
                        case 1:
                            AS.DataSiswa2();
                            break;
                        case 2:
                            Console.WriteLine("Keyword tidak sesuai");
                            Console.ReadKey();
                            break;
                    }
                    Console.WriteLine(" ");
                    Console.Write("Back to Home? (Yes/No)");
                    ulang = Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }