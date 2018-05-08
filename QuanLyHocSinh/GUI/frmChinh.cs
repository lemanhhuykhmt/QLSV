using QuanLyHocSinh.GUI.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.GUI
{
    public partial class frmChinh : Form
    { 
        public frmChinh()
        {
            InitializeComponent();
        }


        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thực sự có muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                // thoát
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            ucGiaoVien frm = new ucGiaoVien();
            frm.Size = new Size(pnlNoiDung.Width, pnlNoiDung.Height);
            frm.Visible = true;
            pnlNoiDung.Controls.Add(frm);
            
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            ucHocSinh frm = new ucHocSinh();
            frm.Size = new Size(pnlNoiDung.Width, pnlNoiDung.Height);
            frm.Visible = true;
            pnlNoiDung.Controls.Add(frm);
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();
            ucMonHoc frm = new ucMonHoc();
            frm.Size = new Size(pnlNoiDung.Width, pnlNoiDung.Height);
            frm.Visible = true;
            pnlNoiDung.Controls.Add(frm);
        }
    }
}
