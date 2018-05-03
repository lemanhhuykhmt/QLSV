using QuanLyHocSinh.Controls;
using QuanLyHocSinh.ExtendModel;
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

namespace QuanLyHocSinh.GUI.Them
{
    public partial class frmThemHS : Form
    {
        public frmThemHS()
        {
            InitializeComponent();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Text);
            LopHoc lop = cbLopHoc.SelectedValue as LopHoc;
            if (kiemTraDuLieu(ten, gioiTinh, ngaySinh, lop))
            {
                string query = "exec themhs @ten , @ngaysinh , @gioitinh , @malh";
                int ketqua = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaySinh, gioiTinh, lop.MaLH });
                if (ketqua > 0)
                {
                    MessageBox.Show("thêm thành công");
                    txtHoTen.Text = "";
                    cbGioiTinh.Text = "Lựa chọn giới tính";
                }
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
            }
        }

        private bool kiemTraDuLieu(string ten, string gioiTinh, DateTime ngaySinh, LopHoc lop)
        {
            if (lop == null) return false;
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmThemHS_Load(object sender, EventArgs e)
        {
            List<LopHoc> listLop = new List<LopHoc>();
            DataTable dt = HocSinhControl.layDanhSachLop();
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                listLop.Add(new LopHoc { MaLH = Convert.ToInt32(dt.Rows[i][0].ToString()), TenLH = dt.Rows[i][1].ToString(), GVCN = dt.Rows[i][2].ToString()});
            }
            cbLopHoc.DataSource = listLop;
            cbLopHoc.DisplayMember = "TenLH";
            cbLopHoc.Text = "Chon lop hoc";

        }
    }
}
