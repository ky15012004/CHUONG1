using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_224, count_224=0;
            Console.WriteLine("Nhap n: ");
            n_224 = int.Parse(Console.ReadLine());

            for(int i=1; i<n_224; i++)
            {
                if (n_224 % i == 0)
                    count_224 += 1;
            }

            if (count_224 > 1)
                Console.WriteLine("{0} khong phai la so nguyen to", n_224);
            else
                Console.WriteLine("{0} la so nguyen to", n_224);

            Console.ReadKey();
        }
    }
}
