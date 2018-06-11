using QuanLyHocSinh.ExtendModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyHocSinh.Controls
{
    class MonHocControl
    {
        private static MonHocControl instance;
        public MonHocControl Instance
        {
            private set { if (instance == null) instance = new MonHocControl(); instance = value; }
            get { return instance; }
        }
        private MonHocControl()
        {

        }
        public static int themDuLieu(int mamon, string tenmon, int sotiet)
        {
            string query = "exec themmn @mamon , @tenmon  , @sotiet";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mamon, tenmon, sotiet });
        }
        public static DataTable layDanhSach() // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from MonHoc";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public static DataTable layThongTin(int id) // lấy thông tin khách hàng có id là ..
        {
            string query = "select * from MonHoc where MaMon = @mamon";//lấy ra thông tin khách hàng có mã
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public static int suaThongTin(int id, string tenmon, int sotiet) // sửa thông tin của khách hàng
        {
            string query = "exec suamh @id , @tenmon , @sotiet ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, tenmon, sotiet, "" });
        }
        public static int xoaThongTin(int id)
        {
            string query = "exec xoamh @mamon";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        public static DataTable timKiem(object obj)
        {
            string str = "%" + obj.ToString() + "%";
            string query = "select * from MonHoc where TenMon like @tenmon or MaMon like @mamon";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { str, str });
        }
    }
}
