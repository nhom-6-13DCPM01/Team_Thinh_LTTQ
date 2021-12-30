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
    public partial class FormViTri : Form
    {
        BindingSource list = new BindingSource();
        public FormViTri()
        {
            InitializeComponent();
            dgvViTri.DataSource = list;
            cbbKhuVuc.DataSource = KhuVucDAO.Instance.GetListKhuVuc();
            cbbKhuVuc.DisplayMember = "MaKhuVuc";
            cbbKhuVuc.ValueMember = "TenKhuVuc";
            LoadViTRi();
            
        }

        void LoadViTRi()
        {
            list.DataSource = ViTriDAO.Instance.GetListViTri();
        }

        void AddViTri(string tenvitri, int makhuvuc, int trangthai)
        {
            if (ViTriDAO.Instance.AddViTri(tenvitri, makhuvuc, trangthai))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            LoadViTRi();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenvitri = txtTenViTri.Text;
            int selectedValue = Convert.ToInt32(cbbKhuVuc.Text); 
            int trangthai = Convert.ToInt32(txtTrangThai.Text);    
            AddViTri(tenvitri, selectedValue, trangthai);

        }

        void DeleteVITri(string tenvitri)
        {

            if (ViTriDAO.Instance.DeleteViTri(tenvitri))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            LoadViTRi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenvitri = txtTenViTri.Text;
            DeleteVITri(tenvitri);
        }

        private void dgvViTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvViTri.CurrentCell.Selected = true;
                txtMaViTri.Text = dgvViTri.Rows[e.RowIndex].Cells["idViTri"].Value.ToString();
                txtTenViTri.Text = dgvViTri.Rows[e.RowIndex].Cells["TenViTri"].Value.ToString();
                cbbKhuVuc.Text = dgvViTri.Rows[e.RowIndex].Cells["MaKhuVuc"].Value.ToString();
                txtTrangThai.Text = dgvViTri.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();

            }
            catch (Exception)
            {

            }
        }
        void UpdateViTri(string tenvitri, int makhuvuc, int trangthai)
        {
            if (ViTriDAO.Instance.UpdateViTri(tenvitri,makhuvuc,trangthai))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadViTRi();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenvitri = txtTenViTri.Text;
            int makhuvuc = Convert.ToInt32(cbbKhuVuc.Text);
            int trangthai = Convert.ToInt32(txtTrangThai.Text);

            UpdateViTri(tenvitri, makhuvuc, trangthai);

        }
    }
}
