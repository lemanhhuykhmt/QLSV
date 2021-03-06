﻿using QuanLyHocSinh.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.GUI.Sua
{
    public partial class frmSuaGV : Form
    {
        private int id;
        public frmSuaGV()
        {
            InitializeComponent();
        }
        public frmSuaGV(int id)
        {
            InitializeComponent();
            this.id = id;
            DataTable dt = GiaoVienControl.layThongTin(id);
            txtTenCu.Text = dt.Rows[0][1].ToString();
            txtGioiTinh.Text = dt.Rows[0][4].ToString();
            txtNgaySinhCu.Text = String.Format("{0:dd/MM/yyyy}", dt.Rows[0][2]);
            txtSDTCu.Text = dt.Rows[0][3].ToString();
            txtLuongCu.Text = dt.Rows[0][5].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMoi.Text;
            string gioitinh = cbGioiTinhMoi.Text;
            string ngaysinh = dtpNgaySinhMoi.Text;
            string sdt = txtSDTMoi.Text;
            double luong = 0;
            if(txtLuongMoi.Text.Length != 0)
            {
                luong = double.Parse(txtLuongMoi.Text);
            }
            if (ckbNgaySinh.Checked == false)
            {
                ngaysinh = "";
            }
            else
            {
                ngaysinh = String.Format("{0:yyyy/MM/dd}", ngaysinh);
            }
            if (kiemTra(ten, gioitinh, ngaysinh, sdt, luong))
            {
                int ketQua = 0;
                ketQua = GiaoVienControl.suaThongTin(id, ten, ngaysinh, sdt, gioitinh, luong);
                if (ketQua > 0)
                {
                    MessageBox.Show("thay đổi thành công");
                    this.Close();
                }
            }
        }
        private bool kiemTra(string ten, string gioitinh, string ngaysinh, string sdt, double luong)
        {
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaGV_Load(object sender, EventArgs e)
        {
            ckbNgaySinh.Checked = false;
            dtpNgaySinhMoi.Enabled = false;
        }

        private void ckbNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaySinhMoi.Enabled = ckbNgaySinh.Checked;
        }
    }
}
