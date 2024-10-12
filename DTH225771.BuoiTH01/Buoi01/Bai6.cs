using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private double basicSalary = 10000;
        private double income;
		
        public Employee()
        {
            id = 0;
            name = "";
            yearOfBirth = 0;
            salaryLevel = 0;
            income = 0;
		}
        public int GetId
        {
            get { return id; }
            set { id = value; }
        }
		
         public string GetName
        {
            get { return name; }
            set { name = value; }
        }
        public int GetYearOfBirth
        {
            get { return yearOfBirth; }
            set { yearOfBirth = value; }
        }
        public double SetSalaryLevel
        {
            get { return salaryLevel; }
            set { salaryLevel = value; }
        }
        public double SetBasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }
        public double GetIncome
        {
            get { return income; }
            set { income = value; }
        }

        public void Input()
        {
            Console.Write(" \t -Nhập id :");
            id = int.Parse(Console.ReadLine());
            Console.Write(" \t -Nhập tên:");
            name = Console.ReadLine();
            Console.Write(" \t -Nhập năm sinh:");
            yearOfBirth = int.Parse(Console.ReadLine());
            Console.Write(" \t -Nhập lương:");
            salaryLevel = double.Parse(Console.ReadLine());
        }
		
        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", id, name, yearOfBirth, salaryLevel, basicSalary, income);
        }

    }
	
	class Program
	{
    	public static void Main()
    	{
        	int n;
        	Console.Write("Nhập số nhân viên: ");
        	n = int.Parse(Console.ReadLine());
        	Employee[] _arrEmployee = new Employee[n];
        	for (int i = 0; i < n; i++)
        	{
            	Console.WriteLine("Nhập thông tin nhân viên thứ: " + (i + 1).ToString());
            	_arrEmployee[i] = new Employee();
            	_arrEmployee[i].Input();
        	}

        	Console.Write("Nhập lương cơ bản: ");
        	double basicSalary = double.Parse(Console.ReadLine());
        	for (int i = 0; i < n; i++)
        	{
            	_arrEmployee[i].SetBasicSalary = basicSalary;
            	_arrEmployee[i].GetIncome = _arrEmployee[i].SetBasicSalary * _arrEmployee[i].SetSalaryLevel;
        	}

        	Console.WriteLine("Danh sách nhân viên: ");
        	Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "id", "name", "yearOfBirth", "salaryLevel", " basicSalary", " income");
        	for (int i = 0; i < n; i++)
        	{
            	_arrEmployee[i].xuat();
        	}
        	Console.ReadLine();
    	}
	}
}
