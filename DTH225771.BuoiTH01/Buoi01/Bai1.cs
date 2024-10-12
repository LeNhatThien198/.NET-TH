using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
	class TimSoLonNhat
    {
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        
        public int TimMax(int so1, int so2, int so3)
        {
            int max;
            max = so1 > so2 ? so1 : so2;
            max = max > so3 ? max : so3;
            return max;
        }
    }
	
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSoLonNhat sln = new TimSoLonNhat();
            int a, b, c, max;
            Console.Write("Nhập a = ");
            a = sln.NhapMotSo();
            Console.Write("\nNhập b = ");
            b = sln.NhapMotSo();
            Console.Write("\nNhập c = ");
            c = sln.NhapMotSo();
            max = sln.TimMax(a, b, c);
            Console.WriteLine("\nSố lớn nhất trong 3 số {0}, {1} và {2} là {3}", a, b, c, max);
            Console.ReadLine();
        }
    }
}
