using QuanLiGiuXe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGiuXe
{
    public partial class FormQuanLyTK : Form
    {
        BindingSource list = new BindingSource();
        public FormQuanLyTK()
        {
            InitializeComponent();
            dgvTaiKhoan.DataSource = list;
            LoadTaiKhoan();
        }

        void LoadTaiKhoan()
        {
            list.DataSource = TaiKhoanDAO.Instance.GetListAccount();
        }

        void Add(string tentk, string matkhau, int idnhanvien)
        {
            if (TaiKhoanDAO.Instance.Insert(tentk, matkhau, idnhanvien))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            LoadTaiKhoan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTK.Text;
            string matkhau = txtMatKhau.Text;
            int idnhanvien = Convert.ToInt32(cbbMaNV.Text);
            Add(tentk, matkhau, idnhanvien);
            LoadTaiKhoan();
        }

        void update(int idtk,string tentk, string matkhau, int idnhanvien)
        {
            if (TaiKhoanDAO.Instance.Update(idtk, tentk, matkhau, idnhanvien))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadTaiKhoan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idtk = Convert.ToInt32(txtMaTK.Text);
            int idnv = Convert.ToInt32(cbbMaNV.Text);
            string tentk = txtTenTK.Text;
            string matkhau = txtMatKhau.Text;
            update(idtk, tentk, matkhau, idnv);
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvTaiKhoan.CurrentCell.Selected = true;
                txtMaTK.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["IdTaiKhoan"].Value.ToString();
                cbbMaNV.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["IdNhanVien"].Value.ToString();
                txtTenTK.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["TaiKhoan"].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();

            }
            catch (Exception)
            {

            }
        }

        void delete(string tentk)
        {
            if (TaiKhoanDAO.Instance.Delete(tentk))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            LoadTaiKhoan();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTK.Text;
            delete(tentk);

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTK.Clear();
            txtMatKhau.Clear();
            txtTenTK.Clear();
            cbbMaNV.Text = null;
            LoadTaiKhoan();
        }
    }
}
