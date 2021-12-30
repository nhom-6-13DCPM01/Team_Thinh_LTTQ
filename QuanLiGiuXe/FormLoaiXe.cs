﻿using QuanLiGiuXe.DAO;
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
    public partial class FormLoaiXe : Form
    {
        BindingSource list = new BindingSource();
        public FormLoaiXe()
        {
            InitializeComponent();
            dgvViTri.DataSource = list;
            LoadLoaiXe();
        }

        void LoadLoaiXe()
        {
            list.DataSource = LoaiXeDAO.Instance.GetListLoaiXe();
        }

        void AddLoaiXe(string tenloaixe, decimal dongia)
        {
            if (LoaiXeDAO.Instance.AddLoaiXe(tenloaixe, dongia))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenloaixe = txtTenLoaiXe.Text;
            Decimal dongia = Convert.ToDecimal(txtDonGia.Text);
            AddLoaiXe(tenloaixe, dongia);
            LoadLoaiXe();

        }

        void UpdateLoaiXe(string tenloaixe,decimal gia)
        {
            if (LoaiXeDAO.Instance.UpdateLoaiXe(tenloaixe, gia))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            LoadLoaiXe();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenloaixe = txtTenLoaiXe.Text;
            decimal gia = Convert.ToDecimal(txtDonGia.Text);
            UpdateLoaiXe(tenloaixe, gia);
            LoadLoaiXe();

        }

        private void dgvViTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvViTri.CurrentCell.Selected = true;
                txtMaLoaiXe.Text = dgvViTri.Rows[e.RowIndex].Cells["IdLoaiXe"].Value.ToString();
                txtTenLoaiXe.Text = dgvViTri.Rows[e.RowIndex].Cells["TenLoaiXe"].Value.ToString();
                txtDonGia.Text = dgvViTri.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
                

            }
            catch (Exception)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtMaLoaiXe.Clear();
            txtTenLoaiXe.Clear();
            LoadLoaiXe();
        }
    }
}
