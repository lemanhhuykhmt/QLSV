using QuanLyHocSinh.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.GUI.ChiTiet
{
    public partial class frmDiemHS : Form
    {
        private int id;
        public frmDiemHS()
        {
            InitializeComponent();
            loadDuLieu();
        }
        public frmDiemHS(int id)
        {
            InitializeComponent();
            this.id = id;
            lbTenHS.Text = DiemControl.layThongTin(id).Rows[0][1].ToString();
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            dgvDanhSach.Rows.Clear();
            DataTable dt = DiemControl.layDanhSachDiemHS(id);
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                double diemmieng = 0;
                double diemgiua = 0;
                double diemcuoi = 0;
                if (dt.Rows[i][2].ToString().Length > 0) { diemmieng = double.Parse(dt.Rows[i][2].ToString()); }
                if (dt.Rows[i][3].ToString().Length > 0)  diemgiua = double.Parse(dt.Rows[i][3].ToString());
                if (dt.Rows[i][4].ToString().Length > 0) diemcuoi = double.Parse(dt.Rows[i][4].ToString());

                double tongket = 0;
                if (diemmieng != 0 && diemgiua != 0 && diemcuoi != 0)
                {
                    tongket = (1 * diemmieng + 2 * diemgiua + 3 * diemcuoi) / 6;
                    dgvDanhSach.Rows.Add(new object[] { i, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], tongket });
                    continue;
                }

                dgvDanhSach.Rows.Add(new object[] { i, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4] });
            }
        }
        private void loadTongKet(int row)
        {
            string mieng = dgvDanhSach.Rows[row].Cells["colDiemMieng"].Value.ToString();
            if (mieng.Length <= 0) return;
            string giua = dgvDanhSach.Rows[row].Cells["colDiemGiuaKi"].Value.ToString();
            if (giua.Length <= 0) return;
            string cuoi = dgvDanhSach.Rows[row].Cells["colCuoiKi"].Value.ToString();
            if (cuoi.Length <= 0) return;
            double tongket = (1 * double.Parse(mieng) + 2 * double.Parse(giua) + 3 * double.Parse(cuoi)) / 6;
            dgvDanhSach.Rows[row].Cells["colTongKet"].Value = tongket;
        }
        private void dgvDanhSach_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex + 1 == dgvDanhSach.RowCount) return;
            int idMH = Convert.ToInt32(dgvDanhSach.Rows[e.RowIndex].Cells["colMa"].Value.ToString());
            if (e.ColumnIndex == dgvDanhSach.Columns["colDiemMieng"].Index) 
            {
                DiemControl.suaDiem(id, idMH, double.Parse(dgvDanhSach.CurrentCell.Value.ToString()), 0, 0);
            }
            else if (e.ColumnIndex == dgvDanhSach.Columns["colDiemGiuaKi"].Index) 
            {
                DiemControl.suaDiem(id, idMH, 0, double.Parse(dgvDanhSach.CurrentCell.Value.ToString()), 0);
            }
            else if (e.ColumnIndex == dgvDanhSach.Columns["colCuoiKi"].Index)
            {
                DiemControl.suaDiem(id, idMH, 0, 0, double.Parse(dgvDanhSach.CurrentCell.Value.ToString()));
            }
            loadTongKet(e.RowIndex);
        }
    }
}
