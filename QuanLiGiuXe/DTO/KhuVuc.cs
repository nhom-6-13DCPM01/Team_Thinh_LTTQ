using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    public class KhuVuc
    {
        private int makhuvuc;
        private string tenkhuvuc;
        private int trangthai;

        public KhuVuc(DataRow row)
        {
            this.Makhuvuc = Convert.ToInt32(row["MAKHUVUC"]);
            this.Tenkhuvuc = row["TenKhuVuc"].ToString();
            this.Trangthai = (int)row["TrangThai"];
        }

        public int Makhuvuc { get => makhuvuc; set => makhuvuc = value; }
        public string Tenkhuvuc { get => tenkhuvuc; set => tenkhuvuc = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
