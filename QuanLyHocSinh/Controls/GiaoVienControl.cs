using QuanLyHocSinh.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Controls
{
    class GiaoVienControl
    {
        private static GiaoVienControl instance;
        public GiaoVienControl Instance
        {
            private set { if (instance == null) instance = new GiaoVienControl(); instance = value; }
            get { return instance; }
        }
        private GiaoVienControl()
        {

        }
        public static int themDuLieu(string ten, DateTime ngaysinh, string sdt, string gioitinh, double luong)
        {
            string query = "exec themgv @ten , @ngaysinh , @sdt , @gioitinh , @luong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, ngaysinh, sdt, gioitinh, luong });
        }
        public static DataTable layDanhSach() // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from GiaoVien";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from GiaoVien where MaGV = @ma";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        //public static string layTenKH(int id)
        //{
        //    if (id == 0)
        //    {
        //        return "";
        //    }
        //    string query = "select TenKH from KhachHang where MaKH = @ma";
        //    return DataProvider.Instance.ExecuteScalar(query, new object[] { id }).ToString();
        //}
        public static int suaThongTin(int id, string ten, DateTime ngaysinh, string sdt, string gioitinh, double luong) // sửa thông tin của khách hàng
        {
            string query = "exec suakh @id , @ten , @ngaysinh , @sdt , @gioitinh , @luong";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, ten, ngaysinh, sdt, gioitinh, luong });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoakh @makh";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from KhachHang where TenKH like @ten or DiaChi like @diachi or SDT like @sdt";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str, str });
        }
    }
}
