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
    public partial class frmSuaMH : Form
    {
        private int id;
        public frmSuaMH()
        {
            InitializeComponent();
        }
        public frmSuaMH(int id)
        {
            InitializeComponent();
            this.id = id;
            DataTable dt = MonHocControl.layThongTin(id);
            txtMMcu.Text = dt.Rows[0][0].ToString();
            txtTMcu.Text = dt.Rows[0][1].ToString();
            txtSTcu.Text = dt.Rows[0][2].ToString();        
        }

       
        private bool kiemTra( string tenmon, int sotiet)
        {
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            string tenmon = txtTMmoi.Text;
            int sotiet = 0;
            
            if (txtSTmoi.Text.Length != 0)
            {
                sotiet = int.Parse(txtSTmoi.Text);
            }
            if (kiemTra( tenmon, sotiet))
            {
                int ketQua = 0;
                ketQua = MonHocControl.suaThongTin(id,tenmon, sotiet);
                if (ketQua > 0)
                {
                    MessageBox.Show("thay đổi thành công");
                    this.Close();
                }
            }
        }
    }
}
