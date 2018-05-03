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
            ucGiaoVien frm = new ucGiaoVien();
            //frm.TopLevel = false;

            //frm.Parent = tc1.Controls[tc1.SelectedIndex];
            frm.Size = new Size(pnlNoiDung.Width, pnlNoiDung.Height);
            frm.Visible = true;
            pnlNoiDung.Controls.Add(frm);
            
        }
    }
}
