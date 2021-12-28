using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    class LoaiXe
    {
        private string tenLoaiXe;
        private decimal donGiaH;
        public LoaiXe(DataRow row)
        {
            this.TenLoaiXe = row["tenLoaiXe"].ToString();
            this.DonGiaH = Convert.ToDecimal(row["donGiaH"]);
        }

        public string TenLoaiXe { get => tenLoaiXe; set => tenLoaiXe = value; }
        public decimal DonGiaH { get => donGiaH; set => donGiaH = value; }
    }
}
