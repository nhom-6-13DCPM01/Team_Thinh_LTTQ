using QuanLiGiuXe.DAO;
using QuanLiGiuXe.DTO;
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
    public partial class FormXeRa : Form
    {
        BindingSource list = new BindingSource();
        public FormXeRa()
        {
            InitializeComponent();
            dataGridView1.DataSource = list;
            LoadXeRa();
            comboBoxLoaiXe.DataSource = LoaiXeDAO.Instance.GetListLoaiXe();
            comboBoxLoaiXe.DisplayMember = "tenLoaiXe";
        }

        void LoadXeRa()
        {
            list.DataSource = SoXeRaDAO.Instance.GetListXeRa();
        }

        void AddXeRa(string bienSo, string loaiXe, DateTime thoiGianRa, string mauXe)
        {
            if (SoXeRaDAO.Instance.AddXeRa(bienSo, loaiXe, thoiGianRa, mauXe))
            {
                MessageBox.Show("Thêm xe vào sổ thành công");
            }
            else
            {
                MessageBox.Show("Thêm xe vào sổ thất bại");
            }

            LoadXeRa();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string bienSo = textBoxBienSoXe.Text;
            string loaiXe = comboBoxLoaiXe.Text;
            DateTime thoiGianRa = dateTimePickerThoiGianRa.Value;
            string mauXe = textBoxMauXe.Text;
            AddXeRa(bienSo, loaiXe, thoiGianRa, mauXe);
        }

        public List<SoXeRa> SearchXeRa(string bienSo)
        {

            List<SoXeRa> list = SoXeRaDAO.Instance.SearchXeRa(bienSo);

            return list;
        }

        public List<SoXeRa> SearchXeTGR(string ngay)
        {

            List<SoXeRa> list = SoXeRaDAO.Instance.SearchXeRaTGR(ngay);

            return list;
        }

        public List<SoXeRa> SearchXeVao(string bienSo)
        {

            List<SoXeRa> list = SoXeRaDAO.Instance.SearchXeRa(bienSo);

            return list;
        }
        private void buttonKiemTraThe_Click(object sender, EventArgs e)
        {
            if (cbbCachTim.Text == "Biển Số")
            {
                list.DataSource = SearchXeVao(txtTuKhoa.Text);
            }
            if (cbbCachTim.Text == "Thời gian ra")
            {
                list.DataSource = SearchXeTGR(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            }
            
        }
    }
}
