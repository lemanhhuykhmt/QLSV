using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.Controls;
using QuanLyHocSinh.GUI.Them;
using QuanLyHocSinh.GUI.Sua;

namespace QuanLyHocSinh.GUI.UC
{
    public partial class ucGiaoVien : UserControl
    {
        public ucGiaoVien()
        {
            InitializeComponent();
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            dgvDanhSach.Rows.Clear();
            DataTable dt = GiaoVienControl.layDanhSach();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                string date = String.Format("{0:dd/MM/yyyy}", dt.Rows[i][2]);
                double luong = double.Parse(dt.Rows[i][5].ToString()) * 1000000;

                dgvDanhSach.Rows.Add(new object[] { false, dt.Rows[i][0], dt.Rows[i][1], date, dt.Rows[i][3], dt.Rows[i][4], luong.ToString("#0,000,000") });

            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmThemGV f = new frmThemGV();
            f.ShowDialog();
            loadDuLieu();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ketQua = 0;
            for (int i = 0; i < dgvDanhSach.Rows.Count - 1; ++i)
            {
                if (Convert.ToBoolean(dgvDanhSach.Rows[i].Cells["colCheck"].Value.ToString()))
                {
                    ketQua += GiaoVienControl.xoaThongTin(Convert.ToInt32(dgvDanhSach.Rows[i].Cells["colMa"].Value.ToString()));
                }
            }
            if (ketQua > 0)
            {
                MessageBox.Show("xóa thành công " + ketQua);
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("xóa thất bại");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timKiem();
        }
        private void timKiem()
        {
            // get text
            string value = txtTimKiem.Text;
            if (value.Length == 0)
            {
                loadDuLieu();
                return;
            }
            dgvDanhSach.Rows.Clear();
            DataTable dt = GiaoVienControl.timKiem(value);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                string date = String.Format("{0:dd/MM/yyyy}", dt.Rows[i][2]);
                double luong = double.Parse(dt.Rows[i][5].ToString()) * 1000000;

                dgvDanhSach.Rows.Add(new object[] { false, dt.Rows[i][0], dt.Rows[i][1], date, dt.Rows[i][3], dt.Rows[i][4], luong.ToString("#0,000,000") });

            }
        }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSach.Rows.Count == e.RowIndex + 1 || e.RowIndex == -1) return;
            int id = Convert.ToInt32(dgvDanhSach.Rows[e.RowIndex].Cells["colMa"].Value.ToString());
            if (e.ColumnIndex == dgvDanhSach.Columns["colSua"].Index)
            {
                frmSuaGV f = new frmSuaGV(id);
                f.ShowDialog();
                loadDuLieu();
            }
            else if (e.ColumnIndex == dgvDanhSach.Columns["colXoa"].Index)
            {
                int ketQua = GiaoVienControl.xoaThongTin(id);
                if (ketQua <= 0)
                {
                    MessageBox.Show("Thực hiện thất bại");
                }
                else
                {
                    loadDuLieu();
                }
            }
            else if(e.ColumnIndex == dgvDanhSach.Columns["colChiTiet"].Index)
            {
                //
            }
        }

        private void txtTimKiem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                timKiem();
            }
            else if (e.KeyValue == 27)
            {
                txtTimKiem.Text = "";
            }
        }
    }
}
