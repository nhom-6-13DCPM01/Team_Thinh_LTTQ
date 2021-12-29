using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    public class SoXeRa
    {
        private int id;
        private string loaixe;
        private string bienSo;
        private string mauXe;
        private DateTime? thoiGianRa;
        public SoXeRa(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Loaixe = row["loaiXe"].ToString();
            this.BienSo = row["bienSo"].ToString();
            this.MauXe = row["mauXe"].ToString();
            this.ThoiGianRa = (DateTime)row["thoiGianRa"];
        }

        public int Id { get => id; set => id = value; }
        public string Loaixe { get => loaixe; set => loaixe = value; }
        public string BienSo { get => bienSo; set => bienSo = value; }
        public string MauXe { get => mauXe; set => mauXe = value; }
        public DateTime? ThoiGianRa { get => thoiGianRa; set => thoiGianRa = value; }
    }
}
