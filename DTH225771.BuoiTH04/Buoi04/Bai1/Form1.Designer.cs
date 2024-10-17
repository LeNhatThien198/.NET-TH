namespace Bai1
{
    partial class frmMangSoNguyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSXGiam = new System.Windows.Forms.Button();
            this.btnSXTang = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnSoNguyenTo = new System.Windows.Forms.Button();
            this.btnTBMang = new System.Windows.Forms.Button();
            this.btnUCLN = new System.Windows.Forms.Button();
            this.btnDemSoLe = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSHH = new System.Windows.Forms.Button();
            this.btnDemSoChan = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(9, 12);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(160, 39);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập 1 Phần Tử";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(317, 12);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(107, 39);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(432, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(573, 12);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 39);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSXGiam
            // 
            this.btnSXGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXGiam.Location = new System.Drawing.Point(573, 59);
            this.btnSXGiam.Margin = new System.Windows.Forms.Padding(4);
            this.btnSXGiam.Name = "btnSXGiam";
            this.btnSXGiam.Size = new System.Drawing.Size(133, 39);
            this.btnSXGiam.TabIndex = 4;
            this.btnSXGiam.Text = "Sắp Xếp Giảm";
            this.btnSXGiam.UseVisualStyleBackColor = true;
            this.btnSXGiam.Click += new System.EventHandler(this.btnSXGiam_Click);
            // 
            // btnSXTang
            // 
            this.btnSXTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXTang.Location = new System.Drawing.Point(573, 106);
            this.btnSXTang.Margin = new System.Windows.Forms.Padding(4);
            this.btnSXTang.Name = "btnSXTang";
            this.btnSXTang.Size = new System.Drawing.Size(133, 39);
            this.btnSXTang.TabIndex = 5;
            this.btnSXTang.Text = "Sắp Xếp Tăng";
            this.btnSXTang.UseVisualStyleBackColor = true;
            this.btnSXTang.Click += new System.EventHandler(this.btnSXTang_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(177, 16);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(132, 31);
            this.txtNhap.TabIndex = 15;
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKQ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKQ.Location = new System.Drawing.Point(13, 59);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(552, 86);
            this.lblKQ.TabIndex = 16;
            this.lblKQ.Click += new System.EventHandler(this.lblKQ_Click);
            // 
            // btnSoNguyenTo
            // 
            this.btnSoNguyenTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoNguyenTo.Location = new System.Drawing.Point(291, 153);
            this.btnSoNguyenTo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoNguyenTo.Name = "btnSoNguyenTo";
            this.btnSoNguyenTo.Size = new System.Drawing.Size(133, 39);
            this.btnSoNguyenTo.TabIndex = 17;
            this.btnSoNguyenTo.Text = "Số Nguyên Tố";
            this.btnSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoNguyenTo.Click += new System.EventHandler(this.btnSoNguyenTo_Click);
            // 
            // btnTBMang
            // 
            this.btnTBMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTBMang.Location = new System.Drawing.Point(248, 200);
            this.btnTBMang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTBMang.Name = "btnTBMang";
            this.btnTBMang.Size = new System.Drawing.Size(175, 39);
            this.btnTBMang.TabIndex = 18;
            this.btnTBMang.Text = "Trung Bình Mảng";
            this.btnTBMang.UseVisualStyleBackColor = true;
            this.btnTBMang.Click += new System.EventHandler(this.btnTBMang_Click);
            // 
            // btnUCLN
            // 
            this.btnUCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUCLN.Location = new System.Drawing.Point(9, 200);
            this.btnUCLN.Margin = new System.Windows.Forms.Padding(4);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(231, 39);
            this.btnUCLN.TabIndex = 19;
            this.btnUCLN.Text = "UCLN 2 Phần Tử Đầu Tiên";
            this.btnUCLN.UseVisualStyleBackColor = true;
            this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click);
            // 
            // btnDemSoLe
            // 
            this.btnDemSoLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSoLe.Location = new System.Drawing.Point(150, 153);
            this.btnDemSoLe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemSoLe.Name = "btnDemSoLe";
            this.btnDemSoLe.Size = new System.Drawing.Size(133, 39);
            this.btnDemSoLe.TabIndex = 25;
            this.btnDemSoLe.Text = "Đếm Số Lẻ";
            this.btnDemSoLe.UseVisualStyleBackColor = true;
            this.btnDemSoLe.Click += new System.EventHandler(this.btnDemSoLe_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(432, 200);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(133, 39);
            this.btnMin.TabIndex = 20;
            this.btnMin.Text = "Số Nhỏ Nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(573, 200);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(133, 39);
            this.btnMax.TabIndex = 24;
            this.btnMax.Text = "Số Lớn Nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSHH
            // 
            this.btnSHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHH.Location = new System.Drawing.Point(432, 153);
            this.btnSHH.Margin = new System.Windows.Forms.Padding(4);
            this.btnSHH.Name = "btnSHH";
            this.btnSHH.Size = new System.Drawing.Size(133, 39);
            this.btnSHH.TabIndex = 21;
            this.btnSHH.Text = "Số Hoàn Hảo";
            this.btnSHH.UseVisualStyleBackColor = true;
            this.btnSHH.Click += new System.EventHandler(this.btnSHH_Click);
            // 
            // btnDemSoChan
            // 
            this.btnDemSoChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSoChan.Location = new System.Drawing.Point(9, 153);
            this.btnDemSoChan.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemSoChan.Name = "btnDemSoChan";
            this.btnDemSoChan.Size = new System.Drawing.Size(133, 39);
            this.btnDemSoChan.TabIndex = 23;
            this.btnDemSoChan.Text = "Đếm Số Chẵn";
            this.btnDemSoChan.UseVisualStyleBackColor = true;
            this.btnDemSoChan.Click += new System.EventHandler(this.btnDemSoChan_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(573, 153);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(133, 39);
            this.btnSum.TabIndex = 22;
            this.btnSum.Text = "Tổng Mảng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // frmMangSoNguyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 251);
            this.Controls.Add(this.btnSoNguyenTo);
            this.Controls.Add(this.btnTBMang);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.btnDemSoLe);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSHH);
            this.Controls.Add(this.btnDemSoChan);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnSXTang);
            this.Controls.Add(this.btnSXGiam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMangSoNguyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mảng Số Nguyên";
            this.Load += new System.EventHandler(this.frmMangSoNguyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSXGiam;
        private System.Windows.Forms.Button btnSXTang;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnSoNguyenTo;
        private System.Windows.Forms.Button btnTBMang;
        private System.Windows.Forms.Button btnUCLN;
        private System.Windows.Forms.Button btnDemSoLe;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSHH;
        private System.Windows.Forms.Button btnDemSoChan;
        private System.Windows.Forms.Button btnSum;
    }
}

