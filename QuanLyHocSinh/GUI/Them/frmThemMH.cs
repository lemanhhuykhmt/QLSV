using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinh.Controls;
using QuanLyHocSinh.ExtendModel;
using QuanLyHocSinh.Models;

namespace QuanLyHocSinh.GUI.Them
{
    public partial class frmThemMH : Form
    {
        public frmThemMH()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenMon.Text;
            string sotiet = txtSoTiet.Text;
            if (kiemTraDuLieu(ten, sotiet))
            {
                string query = "exec themmh  @tenmon , @sotiet";
                int ketqua = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten,  sotiet });
                if (ketqua > 0)
                {
                    MessageBox.Show("thêm thành công");
                    txtTenMon.Text = "";
                    txtSoTiet.Text = "";
                }
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
            }


        }
        private bool kiemTraDuLieu(string ten, string sotiet)
        {
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
