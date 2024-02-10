using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan angka: ");
            int q = int.Parse(Console.ReadLine());
            int[] a = new int[q];
            int r = 0;
            for (int i = 1; i <= q; i++)
            {
                Console.Write($"a[{i}]=");
                a[i - 1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"total {a.Average()}");
            Console.ReadLine();
        }
    }
}
