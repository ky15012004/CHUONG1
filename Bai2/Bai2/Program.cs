using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double result_224 = 0, gt_224 =1;
            int n_224;
            Console.WriteLine("Nhap n: ");
            n_224 = int.Parse(Console.ReadLine());

            for(int i=1; i<=n_224; i++)
            {
                gt_224 *= i;
                result_224 += gt_224;
            }

            Console.WriteLine("ket qua la: {0}", result_224);
            Console.ReadKey();
        }
    }
}
