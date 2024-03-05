using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtongcacphantucuamang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            num[0] = 2;
            Console.WriteLine(num[0]);
            num[1] = 5;
            num[2] = 9;
            Console.WriteLine(num[2]);
            num[3] = 6;
            num[4] = 7;
            Console.WriteLine(num[4]);
            int tong = 0;
            for (int i = 0; i < num.Length; i++)
            {
                tong = tong + num[i];
            }
            Console.WriteLine("Tong la: " + tong.ToString());
            Console.ReadKey();
        }
    }
}
