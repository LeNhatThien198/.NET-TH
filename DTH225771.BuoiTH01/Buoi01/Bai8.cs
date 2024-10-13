 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class PhuongTrinhBac2
    {
		private int Soa;
        private int Sob;
        private int Soc;
		
		public PhuongTrinhBac2()
        {
            Soa = 1;
            Sob = 1;
            Soc = 1;
        }
		public PhuongTrinhBac2(int a, int b, int c)
		{
			Soa = a;
            Sob = b;
            Soc = c;
		}
		public int _Soa
        {
            get { return Soa; }
             set { Soa = value; }
        }
        public int _Sob
        {
            get { return Sob; }
            set { Sob = value; }
        }
        public int _Soc
        {
            get { return Soc; }
            set { Soc = value; }
        }
		public void GiaiPT()
        {
            if (Soa == 0)
            {
                if (Sob == 0)
                {
                    if (Soc == 0)
                    {
                        Console.WriteLine("Phương trình vô số nghiệm");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                }
                else
                {
                    Console.WriteLine("Phương trình có nghiệm x = {0}", -Soc / Sob);
                }
            }
            else
            {
                int delta = Sob * Sob - 4 * Soa * Soc;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}", -Sob / (2 * Soa));
                }
                else
                {
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt");
                    Console.WriteLine("x1 = {0}", (-Sob + Math.Sqrt(delta)) / (2 * Soa));
                    Console.WriteLine("x2 = {0}", (-Sob - Math.Sqrt(delta)) / (2 * Soa));
                }
            }
        }
        public void XuatNghiem()
        {
            Console.WriteLine("Phương trình bậc 2: {0}x\u00B2 + {1}x + {2} = 0", Soa, Sob, Soc);
            GiaiPT();
        }
    }
	class Program
	{
    	public static void Main()
    	{
        	PhuongTrinhBac2 pt = new PhuongTrinhBac2();
        	Console.WriteLine("Nhập hệ số phương trình bậc 2: ");
        	Console.Write("Nhập a: ");
        	pt._Soa = int.Parse(Console.ReadLine());
        	Console.Write("Nhập b: ");
        	pt._Sob = int.Parse(Console.ReadLine());
        	Console.Write("Nhập c: ");
        	pt._Soc = int.Parse(Console.ReadLine());
        	pt.XuatNghiem();
    	}
	}
}
	
