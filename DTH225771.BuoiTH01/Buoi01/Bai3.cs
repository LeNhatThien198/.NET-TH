using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class GiaiThuaN
    {
        public int NhapMotSo()
        {
            int so;
            do
            {
                Console.Write("\nNhập số n = ");
                so = Convert.ToInt32(Console.ReadLine());
                if (so < 0)
                {
                    Console.WriteLine("\nLỗi:Phải nhập (n >= 0). Vui lòng nhập lại.");
                }
            } while (so < 0);
            return so;
        }

        public long TinhGiaiThuaN(int h)
        {
            long gt = 1;
            for (int i = 1; i <= h; i++)
            {
                gt = gt * i;
            }
            return gt;
        }
    }
	
	class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            GiaiThuaN gtn = new GiaiThuaN();
            n = gtn.NhapMotSo();
            Console.WriteLine("Giai thừa của {0} là {1}", n, gtn.TinhGiaiThuaN(n));
            Console.ReadLine();
        }
    }
}
