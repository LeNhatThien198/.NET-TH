using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmMangSoNguyen : Form
    {
        public frmMangSoNguyen()
        {
            InitializeComponent();
        }
        int[] a = new int[10];
        int sopt = 0;
        

        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        public int TimMax()
        {
            int max = a[0];
            for (int i = 1;i<sopt;i++)
            if (a[i] > max)
                  max = a[i];
            return max;
        }
        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            tb = (double)sum / (double)sopt;
            return tb;
        }
        public void SapXepTang()
        {
            Array.Sort(a, 0, sopt);
        }
        public void SapXepGiam()
        {
            Array.Sort(a, 0, sopt, Comparer<int>.Create((x, y) => y.CompareTo(x)));
        }

        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else b = b - a;
            }
            return a;
        }
        public Boolean kiemTraSNT(int so)
        {
            if (so <= 0)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }
        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }
        public String inSNT()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        public int DemSoChan()
        {
            int dem = 0;
            for (int i = 0;i < sopt;i++)
            {
                if (a[i] % 2 == 0)
                    dem++;
            }
            return dem;
        }
        public int DemSoLe()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
            return dem;
        }
        public Boolean kiemTraSHH(int so)
        {
            if (so <= 1)
                return false;
            int tongUoc = 0;

            for (int i = 1; i <= so / 2; i++)
            {
                if (so % i == 0)
                    tongUoc += i;
            }
            return tongUoc == so;
        }
        public int demSHH()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSHH(a[i]))
                    dem++;
            }
            return dem;
        }
        public String inSHH()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSHH(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        public int TongMang()
        {
            int tongMang = 0;
            for (int i = 0; i < sopt; i++)
            {
                tongMang += a[i];
            }
            return tongMang;
        }
        public int Max()
        {
            int max = a[0];
            for (int i = 1; i < sopt; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = a[0];
            for (int i = 1; i < sopt; i++)
            {
                if (a[i] > min)
                {
                    min = a[i];
                }
            }
            return min;
        }


        private void frmMangSoNguyen_Load(object sender, EventArgs e)
        {

        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (this.sopt == this.a.Length)
            {
                this.txtNhap.Text = "";
                MessageBox.Show("Mảng đầy", "Thông báo");
            }
            else
            {
                if (this.txtNhap.Text == "")
                    MessageBox.Show("Hãy nhập phần tử mảng", "Thông báo");
                else
                {
                    a[sopt] = int.Parse(this.txtNhap.Text);
                    sopt++;
                    this.txtNhap.Text += this.txtNhap.Text + " ";
                    this.txtNhap.Clear();
                    this.txtNhap.Focus();
                    if (sopt > 0)
                        this.btnIn.Enabled = true;
                }
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            //xuat cac phan tu co trong mnag
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Các phần tử trong mảng là: \n\r" + InMang();
        }
        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepTang();
                lblKQ.Text = "Đã sắp xếp mảng tăng dần";
            }
        }
        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là " + inSNT();
        }
        private void btnUCLN_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Ước chung lớn nhất 2 phần tử đầu " + a[0] + " và " + a[1] + " là " +
            timUCLN(a[0], a[1]).ToString();
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                DemSoChan();
                lblKQ.Text = "Mảng có " + DemSoChan().ToString() + " là số chẵn ";
            }
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                DemSoLe();
                lblKQ.Text = "Mảng có " + DemSoLe().ToString() + " là số lẻ ";
            }
        }

        private void btnSHH_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSHH().ToString() + " số hoàn hảo là " + inSHH();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Tổng các phần tử trong mảng là: " + TongMang();
        }

        private void btnTBMang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Trung bình các phần tử của mảng là: " + TrungBinhMang();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Số nhỏ nhất trong mảng là: " + Min();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Số lớn nhất trong mảng là: " + Max();
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepGiam();
                this.lblKQ.Text = "Đã sắp xếp mảng giảm dần";
            }
        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }
    }
    }
