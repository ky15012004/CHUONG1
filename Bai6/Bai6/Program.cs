using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            //commit lan 3
            int n_224;
            List<int> soNguyen_224 = new List<int>();
            Console.WriteLine("Nhap n: ");
            n_224 = int.Parse(Console.ReadLine());
            int i = 0;
            while (n_224 > 0)
            {
               
                soNguyen_224.Add(n_224 % 10);
                n_224 = n_224 / 10;
                i++;
            }

            Console.WriteLine("So lon nhat la: {0}", soNguyen_224.Max());
            Console.ReadKey();
        }
    }
}
