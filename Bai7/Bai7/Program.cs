using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            //commit lan3
            int n_224;
            List<int> soNguyen_224 = new List<int>();
            Boolean chk= true;
            Console.WriteLine("Nhap n: ");
            n_224 = int.Parse(Console.ReadLine());
            int number = n_224;
            int i = 0;
            while (n_224 > 0)
            {
                soNguyen_224.Add(n_224 % 10);
                n_224 = n_224 / 10;
                i++;
            }
            
            for(int j=0; j<i-1; j++)
            {
                if (soNguyen_224[j] < soNguyen_224[j + 1])
                {
                    chk = false;
                    break;
                }                         
            }

            if (chk == false)
                Console.WriteLine("so nguyen duong {0} khong phai la so giam dan tu trai qua phai", number);
            else
                Console.WriteLine("so nguyen duong {0} la so giam dan tu trai qua phai", number);
            

            Console.ReadKey();
            
        }
    }
}
