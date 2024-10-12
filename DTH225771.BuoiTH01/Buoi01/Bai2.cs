using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class TimSLN
    {
        public int NhapMotSo()
        {
            int so;
            do
            {
                Console.Write("\nNhập n số nguyên dương: ");
                so = Convert.ToInt32(Console.ReadLine());
                if (so <= 0)
                {
                    Console.WriteLine("\nLỗi: Số phải là số nguyên dương hoặc lớn hơn 0(n>0)! Vui lòng nhập lại.");
                }
            } while (so <= 0);
            return so;
        }

        public int TimMax(int n)
        {
            int max, i, sotam;
            max = 0;
            i = 0;
            do
            {
                Console.Write("\nNhập vào số thứ {0} = ", i + 1);
                sotam = Convert.ToInt32(Console.ReadLine());
                if (max < sotam)
                    max = sotam;
                i++;
            } while (i < n);
            return max;
        }
    }
	
	class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSLN sln = new TimSLN();
            int n;
            n = sln.NhapMotSo();
            Console.WriteLine("\n Số lớn nhất trong {0} số vừa nhập là {1}", n, sln.TimMax(n));
            Console.ReadLine();
        }
    }
}
