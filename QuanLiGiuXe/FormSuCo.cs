using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiGiuXe
{
    public partial class FormSuCo : Form
    {
        private SqlConnection connection;
        private String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=DBCuoiKy;Integrated Security=True";
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();

        public FormSuCo()
        {
            InitializeComponent();
        }

        private void soXeVao(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewSoXeVao.DataSource = table;
            connection.Close();
        }

        private void soXeRa(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridViewSoXeRa.DataSource = table;
            connection.Close();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if(!textBoxBienSoXe.Text.Equals(null) && !textBoxBaiDo.Text.Equals(null))
            {
                
            }
        }

        private void FormSuCo_Load(object sender, EventArgs e)
        {
            soXeVao("SELECT SoXeVao.IdSoXeVao, SoXeVao.IdTheXe, SoXeVao.NgayTao, LoaiXe.TenLoaiXe, TheXe.BienSo, KhuVuc.TenKhuVuc, ViTri.idViTri, KhuVuc.MaKhuVuc FROM SoXeVao INNER JOIN TheXe ON SoXeVao.IdTheXe = TheXe.IdTheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe INNER JOIN ViTri ON TheXe.IdViTri = ViTri.idViTri INNER JOIN KhuVuc ON ViTri.MaKhuVuc = KhuVuc.MaKhuVuc");
            soXeRa("SELECT SoXeRa.IdSoXeRa, SoXeRa.IdTheXe, SoXeRa.NgayLay, LoaiXe.IdLoaiXe, LoaiXe.TenLoaiXe, TheXe.BienSo FROM SoXeRa INNER JOIN TheXe ON SoXeRa.IdSoXeRa = TheXe.IdTheXe INNER JOIN LoaiXe ON TheXe.IdLoaiXe = LoaiXe.IdLoaiXe");
        }
    }
}
