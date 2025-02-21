using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            //commit lan3
            int a_224, b_224;

            Console.WriteLine("Nhap a: ");
            a_224 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            b_224 = int.Parse(Console.ReadLine());

            while(a_224 != b_224)
            {
                if (a_224 > b_224)
                    a_224 = a_224 - b_224;
                else
                    b_224 = b_224 - a_224;
            }

            Console.WriteLine("Uoc so chung lon nhat la: {0}", a_224);
            Console.ReadKey();

        }
    }
}
