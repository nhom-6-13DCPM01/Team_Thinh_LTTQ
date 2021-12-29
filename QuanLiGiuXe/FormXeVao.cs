using QuanLiGiuXe.DAO;
using QuanLiGiuXe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGiuXe
{
    public partial class FormXeVao : Form
    {
        BindingSource list = new BindingSource();
        public FormXeVao()
        {
            InitializeComponent();
            dataGridViewXe.DataSource = list;
            LoadXeVao();
            comboBoxLoaiXe.DataSource = SoXeVaoDAO.Instance.GetListLoaiXe();
            comboBoxLoaiXe.DisplayMember = "tenLoaiXe";


        }

        void LoadXeVao()
        {
            list.DataSource = SoXeVaoDAO.Instance.GetListXeVao();
        }

        void DeleteXeRa(string bienSo)
        {

            if (SoXeVaoDAO.Instance.DeleteXeVao(bienSo))
            {
                MessageBox.Show("Xóa xe thành công");
            }
            else
            {
                MessageBox.Show("Xóa xe thất bại");
            }

            LoadXeVao();
        }

        void AddXeVao(string bienSo, string loaiXe, int idBaiDo, DateTime thoiGianVao, string mauXe)
        {
            if (SoXeVaoDAO.Instance.AddXeVao(bienSo, loaiXe, idBaiDo, thoiGianVao, mauXe))
            {
                MessageBox.Show("Thêm xe vào sổ thành công");
            }
            else
            {
                MessageBox.Show("Thêm xe vào sổ thất bại");
            }

            LoadXeVao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bienSo = textBoxBienSoXe.Text;

            DeleteXeRa(bienSo);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string bienSo = textBoxBienSoXe.Text;
            string loaiXe = comboBoxLoaiXe.Text;
            DateTime thoiGianVao = dateTimePickerThoiGianVao.Value;
            string mauXe = textBoxMauXe.Text;
            int idBaiDo = 1;

            AddXeVao(bienSo, loaiXe, idBaiDo, thoiGianVao, mauXe);
        }

        public List<SoXeVao> SearchXeVao(string bienSo)
        {

            List<SoXeVao> list = SoXeVaoDAO.Instance.SearchXeVao(bienSo);

            return list;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            list.DataSource = SearchXeVao(txtTKxe.Text);
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            txtTKxe.Clear();
            LoadXeVao();    
        }
    }
}
