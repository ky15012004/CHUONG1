using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            //commit lan3
            int n_224, sum_224=0, k_224=0;
            Console.WriteLine("Nhap n: ");
            n_224 = int.Parse(Console.ReadLine());


            while(sum_224 + (k_224 + 1) < n_224)
            {
                k_224++;
                sum_224 += k_224;
            }

            Console.WriteLine("Gia tri k lon nhat la: {0}"  ,k_224);
            Console.ReadKey();
        }
    }
}
