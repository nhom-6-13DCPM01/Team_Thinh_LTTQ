using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    public class SoXeVao
    {
        private int id;
        private string loaixe;
        private string bienSo;
        private string mauXe;
        private DateTime? thoiGianVao;
        public SoXeVao(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Loaixe = row["loaiXe"].ToString();
            this.BienSo = row["bienSo"].ToString();
            this.MauXe = row["mauXe"].ToString();
            this.ThoiGianVao = (DateTime)row["thoiGianVao"];
        }

        public int Id { get => id; set => id = value; }
        public string Loaixe { get => loaixe; set => loaixe = value; }
        public string BienSo { get => bienSo; set => bienSo = value; }
        public DateTime? ThoiGianVao { get => thoiGianVao; set => thoiGianVao = value; }
        public string MauXe { get => mauXe; set => mauXe = value; }
    }
}
