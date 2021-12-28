using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        internal static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT tenTaiKhoan, tenNhanVien, Type FROM dbo.Account");
        }
    }
}
