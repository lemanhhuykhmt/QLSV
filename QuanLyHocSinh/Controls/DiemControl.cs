using QuanLyHocSinh.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Controls
{
    class DiemControl // ato
    {
        private static DiemControl instance;
        public DiemControl Instance
        {
            private set { if (instance == null) instance = new DiemControl(); instance = value; }
            get { return instance; }
        }
        private DiemControl()
        {

        }
        public static DataTable layDanhSachDiemHS(int id)
        {
            string query = "select d.MaMon, mh.TenMon, d.DiemMieng, d.DiemGiuaKi, d.DiemCuoiKi " +
                " from Diem as d, MonHoc as mh where d.MaMon = mh.MaMon and MaHS = @ma";
            return DataProvider.Instance.ExecuteQuery(query,new object[]{ id});
        }
        public static DataTable layThongTin(int id)
        {
            string query = "select MaHS, TenHS, NgaySinh, GioiTinh, TenLop " +
                 " from HocSinh as hs, LopHoc as lh where hs.MaLop = lh.MaLop and hs.MaHS = @ma";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public static void suaDiem(int mahs, int mamon, double diemmieng, double diemgiua, double diemcuoi)
        {
            string query = "exec suadiem @mahs , @mamon , @diemmieng , @diemgiua , @diemcuoi";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahs, mamon, diemmieng, diemgiua, diemcuoi});
        }
    }
}
