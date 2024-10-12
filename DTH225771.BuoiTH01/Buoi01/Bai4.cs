using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class MangSoNguyen
    {
        public int NhapMotSo()
        {
            int so;
            do
            {
                Console.Write("\nNhập vào mảng có n phần từ (n > 1): ");
                so = Convert.ToInt32(Console.ReadLine());
                if (so < 1)
                {
                    Console.WriteLine("\nLỗi:Phải nhập (n > 1). Vui lòng nhập lại.");
                }
            } while (so < 1);
            return so;
        }

        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
        }

        public int TimSoLonNhat(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        public int TimSoNhoNhat(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        public int TinhTong(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        public void SapXepTangDan(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
	
	class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MangSoNguyen msn = new MangSoNguyen();
            int n;
            n = msn.NhapMotSo();
            int[] a = new int[n];
            msn.NhapMang(a);
            Console.WriteLine("\nMảng vừa nhập ");
            msn.InMang(a);
            Console.WriteLine("\nSố lớn nhất trong mảng {0}", msn.TimSoLonNhat(a));
            Console.WriteLine("\nSố nhỏ nhất trong mảng {0}", msn.TimSoNhoNhat(a));
            Console.WriteLine("\nTổng các phần tử trong mảng là: {0}", msn.TinhTong(a));
            Console.WriteLine("\nMảng sau khi sắp tăng dần ");
            msn.SapXepTangDan(a);
            msn.InMang(a);
            Console.ReadLine();
        }
    }
}
