using QuanLiGiuXe.DAO;
using QuanLiGiuXe.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiGiuXe
{
    public partial class FormQuanLyKhuVuc : Form
    {
        BindingSource list = new BindingSource();
        public FormQuanLyKhuVuc()
        {
            InitializeComponent();
            dataGridView1.DataSource = list;
            LoadKhuVuc();
        }

        void LoadKhuVuc()
        {
            list.DataSource = KhuVucDAO.Instance.GetListKhuVuc();
        }

        void AddKhuVuc(string tenkhuvuc, string trangthai)
        {
            if (KhuVucDAO.Instance.AddKhuVuc(tenkhuvuc, trangthai))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            LoadKhuVuc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenkhuvuc = txtTenKhuVuc.Text;
            string trangthai = txtTrangThai.Text;
            AddKhuVuc(tenkhuvuc, trangthai);
        }

        void DeleteKhuVuc(string tenkhuvuc)
        {

            if (KhuVucDAO.Instance.DeleteKhuVuc(tenkhuvuc))
            {
                MessageBox.Show("Xóa Khu vực thành công");
            }
            else
            {
                MessageBox.Show("Xóa khu vực thất bại");
            }

            LoadKhuVuc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenkhuvuc = txtTenKhuVuc.Text;
            DeleteKhuVuc(tenkhuvuc);
        }

        void UpdateKhuVuc(string tenkhuvuc, int trangthai)
        {
            if (KhuVucDAO.Instance.UpdateKhuVuc(tenkhuvuc, trangthai))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadKhuVuc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string tenkhuvuc = txtTenKhuVuc.Text;
            int trangthai = Convert.ToInt32(txtTrangThai.Text);

            UpdateKhuVuc(tenkhuvuc, trangthai);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell.Selected = true;
                txtMaKhuVuc.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKhuVuc"].Value.ToString();
                txtTenKhuVuc.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKhuVuc"].Value.ToString();
                txtTrangThai.Text = dataGridView1.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
