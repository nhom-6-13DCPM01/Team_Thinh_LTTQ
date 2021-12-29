using QuanLiGiuXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DAO
{
    class SoXeVaoDAO
    {
        private static SoXeVaoDAO instance;
        public static SoXeVaoDAO Instance
        {
            get { if (instance == null) instance = new SoXeVaoDAO(); return SoXeVaoDAO.instance; }
            private set { SoXeVaoDAO.instance = value; }
        }

        private SoXeVaoDAO() { }

        public DataTable GetListXeVao()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.SoXeVao");
        }

        public DataTable GetListLoaiXe()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LoaiXe");
        }
        /*public string GetListLoaiXe(string loaiXe)
        {
            string query = "SELECT loaiXe FROM SoXeVao WHERE name = '" + loaiXe + "'";
            string nameCategory = DataProvider.Instance.ExecuteScalar(query).ToString();
            return nameCategory;
        }*/
        /* public string GetListLoaiXe(string loaixe)
         {
             string query = "SELECT loaiXe FROM SoXeVao";
             string nameCategory = DataProvider.Instance.ExecuteScalar(query, new object[] { loaixe }).ToString();
             return nameCategory;
         }*/

        public bool DeleteXeVao(string bienSo)
        {
            string query = string.Format("Delete SoXeVao where bienSo = N'{0}'", bienSo);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool AddXeVao(string bienSo, string loaiXe, int idBaiDo, DateTime thoiGianVao, string mauXe)
        {
            string query = string.Format("INSERT dbo.SoXeVao ( bienSo, loaiXe, idBaiDo ,thoiGianVao,mauXe )VALUES  ( N'{0}', N'{1}','{2}' ,N'{3}', N'{4}')", bienSo, loaiXe, idBaiDo, thoiGianVao, mauXe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<SoXeVao> SearchXeVao(string bienSo)
        {
            List<SoXeVao> list = new List<SoXeVao>();

            string query = "SELECT * FROM SoXeVao WHERE bienSo = @bienSo";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { bienSo });

            foreach (DataRow item in data.Rows)
            {
                SoXeVao xe = new SoXeVao(item);
                list.Add(xe);
            }

            return list;
        }

    }
}
