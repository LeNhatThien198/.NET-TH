using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class TamGiac
    {
        private int Canh1;
        private int Canh2;
        private int Canh3;
        private int Chuvi;
        private string loaiTamGiac;
        private float Dientich;
		
       public TamGiac()
        {
            Canh1 = 2;
            Canh2 = 3;
            Canh3 = -5;
        }
		public TamGiac(int a, int b, int c)
		{
			Canh1 = a;
			Canh2 = b;
			Canh3 = c;
		}
		public int TinhChuVi()
        {
            Chuvi = Canh1 + Canh2 + Canh3;
            return Chuvi;
        }
        public float TinhDienTich()
        {
			TinhChuVi();
            float p = (float)Chuvi / 2;
            Dientich = (float)Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
            return Dientich;
        }
		public string XetLoaiTamGiac()
        {
            if (Canh1 == Canh2 && Canh2 == Canh3)
            {
                loaiTamGiac = "Tam giác đều";
            }
            else if (Canh1 == Canh2 || Canh2 == Canh3 || Canh1 == Canh3)
            {
                loaiTamGiac = "Tam giác cân";
            }
            else
            {
                loaiTamGiac = "Tam giác thường";
            }
            return loaiTamGiac;
        }

        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", Canh1, Canh2, Canh3, Chuvi, Dientich, loaiTamGiac);
        }
    }
	
	class Program
	{
    	public static void Main()
    	{
        	int n;
        	Console.Write("Nhập số tam giác: ");
        	n = int.Parse(Console.ReadLine());
        	TamGiac[] _arrTamGiac = new TamGiac[n];
        	for (int i = 0; i < n; i++)
        	{
            	Console.WriteLine("Nhập tam giác thứ: " + (i + 1).ToString());
            	Console.Write("Nhập a: ");
            	int a = int.Parse(Console.ReadLine());
            	Console.Write("Nhập b: ");
            	int b = int.Parse(Console.ReadLine());
            	Console.Write("Nhập c: ");
            	int c = int.Parse(Console.ReadLine());
            	_arrTamGiac[i] = new TamGiac(a, b, c);
            	_arrTamGiac[i].TinhChuVi();
            	_arrTamGiac[i].TinhDienTich();
            	_arrTamGiac[i].XetLoaiTamGiac();
        	}

        	Console.WriteLine("Danh sách tam giác: ");
        	Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "Cạnh 1", "Cạnh 2", "Cạnh 3", "Chu vi", "Diện tích", "Loại tam giác");
        	for (int i = 0; i < n; i++)
        	{
            	_arrTamGiac[i].xuat();
        	}
        	Console.ReadLine();
    	}
	}
}
