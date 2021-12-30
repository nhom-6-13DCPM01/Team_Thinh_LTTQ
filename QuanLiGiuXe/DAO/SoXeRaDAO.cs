using QuanLiGiuXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class SoXeRaDAO
    {
        private static SoXeRaDAO instance;
        public static SoXeRaDAO Instance
        {
            get { if (instance == null) instance = new SoXeRaDAO(); return SoXeRaDAO.instance; }
            private set { SoXeRaDAO.instance = value; }
        }

        private SoXeRaDAO() { }

        public DataTable GetListXeRa()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.SoXeRa");
        }

        public bool AddXeRa(string bienSo, string loaiXe, DateTime thoiGianRa, string mauXe)
        {
            string query = string.Format("INSERT dbo.SoXeRa ( bienSo, loaiXe,thoiGianRa,mauXe, tongTien)VALUES  ( N'{0}', N'{1}','{2}' ,N'{3}', N'{4}')", bienSo, loaiXe, thoiGianRa, mauXe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<SoXeRa> SearchXeRa(string bienSo)
        {
            List<SoXeRa> list = new List<SoXeRa>();

            string query = "SELECT * FROM SoXeRa WHERE bienSo like @bienSo";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { bienSo });

            foreach (DataRow item in data.Rows)
            {
                SoXeRa xe = new SoXeRa(item);
                list.Add(xe);
            }

            return list;
        }

        public List<SoXeRa> SearchXeRaTGR(string thoiGian)
        {
            List<SoXeRa> list = new List<SoXeRa>();

            string query = "SELECT * FROM SoXeRa WHERE CONVERT(varchar,thoiGianRa,103) like @thoiGian";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { thoiGian });

            foreach (DataRow item in data.Rows)
            {
                SoXeRa xe = new SoXeRa(item);
                list.Add(xe);
            }

            return list;
        }

    }
}
