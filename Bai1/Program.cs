using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args) // entry point
        {
            Console.WriteLine("Nhap so N: ");
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("tong la: " + Tong(n));
            Console.WriteLine("Nhap mang: ");
            int[] a = new int[n];
            nhapMang(a, n);
            Console.WriteLine("Tong la: " + Tong(a, n));

        }

        static void nhapMang(int[] a, int n)
        {
            for(int i = 0; i< n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void xuatMang(int[] a, int n)
        {
            for(int i = 0; i< n; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }

        static int Tong(int[] a, int n)
        {
            if (n == 1) return a[0];
            return a[n-1]+ Tong(a, n - 1);
        }

        static int Tong(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n % 2 == 0)
            {
                return Tong(n - 1);
            }
            return n + Tong(n - 1);
        }
    }
}
