using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x_224, n_224, P_224 =0;
            double result_224 = 0;

            Console.WriteLine("Nhap gia tri x: ");
            x_224 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap gia tri n: ");
            n_224 = int.Parse(Console.ReadLine());

            for(int i=1; i <= n_224; i++)
            {
                if (i %2== 0)
                {
                    P_224 += i;
                    result_224 += Math.Pow(x_224, i)/P_224;
                }
                else
                {
                    P_224 += i;
                    result_224 += -Math.Pow(x_224, i) / P_224;
                }
            }

            Console.WriteLine("ket qua la: {0}", result_224);
            Console.ReadKey();
        }
    }
}
