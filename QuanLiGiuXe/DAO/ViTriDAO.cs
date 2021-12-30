using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class ViTriDAO
    {
        private static ViTriDAO instance;
        public static ViTriDAO Instance
        {
            get { if (instance == null) instance = new ViTriDAO(); return ViTriDAO.instance; }
            private set { ViTriDAO.instance = value; }
        }

        private ViTriDAO() { }

        public DataTable GetListViTri()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ViTri");
        }
        public bool AddViTri(string tenvitri, int makhuvuc, int trangthai)
        {
            string query = string.Format("INSERT dbo.ViTri ( TenViTri, MaKhuVuc, TrangThai)VALUES  ( N'{0}', N'{1}','{2}')", tenvitri, makhuvuc, trangthai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool DeleteViTri(string tenvitri)
        {
            string query = "delete ViTri Where TenViTri = @tenvitri and TrangThai = 0";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenvitri });

            return result > 0;
        }

        public bool UpdateViTri(string tenvitri, int makhuvuc, int trangthai)
        {
            string query = string.Format("UPDATE dbo.ViTri SET TenViTri = N'{0}', MaKhuVuc = '{2}' , TrangThai = '{1}'", tenvitri, trangthai,makhuvuc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
