using QuanLyHocSinh.Controls;
using QuanLyHocSinh.Models;
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
    public partial class frmSuaHS : Form
    {
        private int id;
        public frmSuaHS()
        {
            InitializeComponent();
        }
        public frmSuaHS(int id)
        {
            InitializeComponent();
            List<LopHoc> listLop = new List<LopHoc>();
            DataTable dt = HocSinhControl.layDanhSachLop();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                listLop.Add(new LopHoc { MaLH = Convert.ToInt32(dt.Rows[i][0].ToString()), TenLH = dt.Rows[i][1].ToString(), GVCN = dt.Rows[i][2].ToString() });
            }
            cbTenLop.DataSource = listLop;
            cbTenLop.DisplayMember = "TenLH";
            this.id = id;
            dt = HocSinhControl.layThongTin(id);
            txtTenCu.Text = dt.Rows[0][1].ToString();
            txtGioiTinh.Text = dt.Rows[0][3].ToString();
            txtNgaySinhCu.Text = String.Format("{0:dd/MM/yyyy}", dt.Rows[0][2]);
            txtTenLopCu.Text = dt.Rows[0][4].ToString();
            cbTenLop.SelectedIndex = cbTenLop.FindStringExact(dt.Rows[0][4].ToString());
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMoi.Text;
            string gioitinh = cbGioiTinhMoi.Text;
            string ngaysinh = dtpNgaySinhMoi.Text;
            if (ckbNgaySinh.Checked == false)
            {
                ngaysinh = "";
            }
            else
            {
                ngaysinh = String.Format("{0:yyyy/MM/dd}", ngaysinh);
            }
            if (kiemTra(ten, gioitinh, ngaysinh))
            {
                int ketQua = 0;
                ketQua = HocSinhControl.suaThongTin(id, ten, ngaysinh, gioitinh, 4);
                if (ketQua > 0)
                {
                    MessageBox.Show("thay đổi thành công");
                    this.Close();
                }
            }
        }
        private bool kiemTra(string ten, string gioitinh, string ngaysinh)
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

        private void frmSuaHS_Load(object sender, EventArgs e)
        {
            //List<LopHoc> listLop = new List<LopHoc>();
            //DataTable dt = HocSinhControl.layDanhSachLop();
            //for (int i = 0; i < dt.Rows.Count; ++i)
            //{
            //    listLop.Add(new LopHoc { MaLH = Convert.ToInt32(dt.Rows[i][0].ToString()), TenLH = dt.Rows[i][1].ToString(), GVCN = dt.Rows[i][2].ToString() });
            //}
            //cbTenLop.DataSource = listLop;
            //cbTenLop.DisplayMember = "TenLH";
        }
    }
}
