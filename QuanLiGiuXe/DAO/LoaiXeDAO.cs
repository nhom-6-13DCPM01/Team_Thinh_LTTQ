using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class LoaiXeDAO
    {
        private static LoaiXeDAO instance;
        public static LoaiXeDAO Instance
        {
            get { if (instance == null) instance = new LoaiXeDAO(); return LoaiXeDAO.instance; }
            private set { LoaiXeDAO.instance = value; }
        }

        private LoaiXeDAO() { }

        public DataTable GetListLoaiXe()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LoaiXe");
        }
    }
}
