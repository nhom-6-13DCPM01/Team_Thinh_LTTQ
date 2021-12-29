using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    public class LoaiXe
    {
        private string tenLoaiXe;
        private decimal donGia;
        public LoaiXe(DataRow row)
        {
            this.TenLoaiXe = row["tenLoaiXe"].ToString();
            this.DonGia = (decimal)(row["donGia"]);
        }

        public string TenLoaiXe { get => tenLoaiXe; set => tenLoaiXe = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
    }
}
