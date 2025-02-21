using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_224, result_224 = 0;
            Console.WriteLine("Nhap n: ");
            n_224 = int.Parse(Console.ReadLine());

            for(int i=1; i<=n_224; i++)
            {
                if (n_224 % i == 0)
                    result_224 += i;
            }

            Console.WriteLine("ket qua la: {0}", result_224);
            Console.ReadKey();
        }
    }
}
