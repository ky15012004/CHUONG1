using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            //commit lan3
            int n_224, result_224 = 0;
            Console.WriteLine("Nhap n: ");
            n_224 = int.Parse(Console.ReadLine());

            for(int i=1; i<=n_224; i++)
            {
                result_224 += i;
            }

            Console.WriteLine("Tong la: {0}", result_224);
            Console.ReadKey();
        }
    }
}
