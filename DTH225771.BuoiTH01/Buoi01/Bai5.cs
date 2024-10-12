using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Student
    {
        private string _hoTen;
        private int _tuoi;
        private double _diemToan;
        private double _diemVan;
        private double _dtb;
		
        public Student()
        {
            HoTen = "";
            DiemVan = 0;
            DiemToan = 0;
            Dtb = 0;
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
		
        public int Tuoi
        {
            get { return _tuoi; }
            set { _tuoi = value; }
        }
		
        public double DiemToan
        {
            get { return _diemToan; }
            set { _diemToan = value; }
        }
		
        public double DiemVan
        {
            get { return _diemVan; }
            set { _diemVan = value; }
        }
		
        public double Dtb
        {
            get { return Math.Round(((DiemToan + DiemVan) / 2), 2); }
            set { _dtb = value; }
        }

        public void nhap()
        {
            Console.Write(" \t -Nhập họ tên:");
            HoTen = Console.ReadLine();
            Console.Write(" \t -Nhập điểm toán:");
            Double temp;
            temp = double.Parse(Console.ReadLine());
            if (temp > 10 || temp < 0)
            {
                Console.WriteLine(" \t !!! Điểm phải nằm trong khoảng 0 -> 10");
                Console.Write(" \t -Nhập lại điểm toán:");
                temp = double.Parse(Console.ReadLine());
            }
            DiemToan = temp;
            Console.Write(" \t -Nhập điểm văn:");
            temp = double.Parse(Console.ReadLine());
            if (temp > 10 || temp < 0)
            {
                Console.WriteLine(" \t !!! Điểm phải nằm trong khoảng 0 -> 10");
                Console.Write(" \t -Nhập lại điểm văn:");
                temp = double.Parse(Console.ReadLine());
            }
            DiemVan = temp;
        }
		
        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", HoTen, DiemToan, DiemVan, Dtb);
        }
		
	}
	
	class Program
	{
    	public static void Main()
    	{
        	int n;
        	Console.Write(" Nhập số lượng sinh viên: ");
        	n = int.Parse(Console.ReadLine());
        	Student[] _arrStudent = new Student[n];
        	for (int i = 0; i < n; i++)
        	{
            	Console.WriteLine(" Nhập thông tin sinh viên: " + (i + 1).ToString());
            	_arrStudent[i] = new Student();
            	_arrStudent[i].nhap();
       	 	}
        	Console.WriteLine(" Danh sách sinh viên: ");
        	Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Họ Tên", "Điểm Toán", "Điểm Văn", "ĐTB");
        	for (int i = 0; i < n; i++)
        	{
            	_arrStudent[i].xuat();
        	}
        	Console.ReadLine();
    	}
	}
}
