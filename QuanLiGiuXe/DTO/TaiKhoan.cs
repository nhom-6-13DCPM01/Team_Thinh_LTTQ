using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe.DTO
{
    class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string tenNhanVien;
        private bool vaiTro;

        public TaiKhoan(DataRow row)
        {
            this.TenTaiKhoan = row["tenTaiKhoan"].ToString();
            this.TenNhanVien = row["tenNhanVien"].ToString();
            this.VaiTro = (Boolean)row["vaiTro"];
            this.MatKhau = row["matKhau"].ToString();
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public bool VaiTro { get => vaiTro; set => vaiTro = value; }
    }
}
