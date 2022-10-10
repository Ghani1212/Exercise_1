using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        //deklarasi array menggunakan jumlah nama lalu + 10 + 20 + 20 -2 x 15
        private int[] a = new int[33];
        
        //deklarasi variabel int untuk menyimpan byk data pada array 
        private int n;
        
        
        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya element pada array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 33)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 33 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("----------------------");
           
            //pengguna memasukkan element pada array 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {   
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang sudah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int gr = 0; gr < n; gr++)
            {
               
                Console.WriteLine(a[gr]);
            }
            Console.WriteLine("");
        }   
        
        public void BubbleSortArray()
        {
            for (int gr = 1; gr < n - 1; gr++) //for n -1 passes
            {
               
                if (a[gr] > a[n - 1])//varying from gr + 1 to n - 1
                 

                {
                    int temp;
                    temp = a[gr];
                    a[gr] = a[n - 1];
                    a[n - 1] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            //membuat objek dari bubblesortclass
            Program myList = new Program();

            //pemanggilan fungsi untuk menerima elemen array
            myList.read();
            //pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            //pemanggilan fungsi untuk menampilkan array yang tersusun 
            myList.display();
            //exit
            Console.WriteLine("\n\n Tekn tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}
