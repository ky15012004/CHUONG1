using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            //commit lan3
            float a, b, c, max;

            Console.WriteLine("Nhap a: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap b: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap c: ");
            c = float.Parse(Console.ReadLine());

            max = a;

            if (max < b)
                max = b;
            if (max < c)
                max = c;

            Console.WriteLine("So lon nhat la: {0}", max);
            Console.ReadKey();
        }
    }
}
