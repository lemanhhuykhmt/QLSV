using QuanLyHocSinh.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Controls
{
    class HocSinhControl
    {
        private static HocSinhControl instance;
        public HocSinhControl Instance
        {
            private set { if (instance == null) instance = new HocSinhControl(); instance = value; }
            get { return instance; }
        }
        private HocSinhControl()
        {

        }
        public static int themDuLieu(string ten, DateTime ngaysinh, string gioitinh, int malop)
        {
            string query = "exec themhs @ten , @ngaysinh , @gioitinh , @malop";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaysinh, gioitinh, malop });
        }
        public static DataTable layDanhSach() // lấy thông tin khách hàng có id là ..
        {
            string query = "select MaHS, TenHS, NgaySinh, GioiTinh, TenLop " +
                " from HocSinh as hs, LopHoc as lh where hs.MaLop = lh.MaLop";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select MaHS, TenHS, NgaySinh, GioiTinh, TenLop " +
                 " from HocSinh as hs, LopHoc as lh where hs.MaLop = lh.MaLop and hs.MaHS = @ma";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }

        public static int suaThongTin(int id, string ten, string ngaysinh, string gioitinh, int malop) // sửa thông tin của khách hàng
        {
            string query = "exec suahs @id , @ten , @ngaysinh , @gioitinh , @malop";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, ngaysinh, gioitinh, malop });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoahs @ma";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select hs.MaHS, hs.TenHS, hs.NgaySinh, hs.GioiTinh, lh.TenLop from HocSinh as hs, LopHoc as lh where hs.MaLop = lh.MaLop "
                + " and (hs.TenHS like @tenhs or lh.TenLop like @tenlop )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str });
        }
        public static DataTable layDanhSachLop()
        {
            string query = "select lh.MaLop, lh.TenLop, gv.TenGV from LopHoc as lh, GiaoVien as gv where lh.GVCN = gv.MaGV";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
