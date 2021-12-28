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
    public partial class FormTrangChinh : Form
    {
        SqlConnection connection;
        String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=BaiGiuXe;Integrated Security=True";
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public FormTrangChinh()
        {
            InitializeComponent();
        }

        private void load_data_chart(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            chartDoanhThu.DataSource = table;
            chartDoanhThu.Series["DoanhThu"].XValueMember = "Tháng";
            chartDoanhThu.Series["DoanhThu"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartDoanhThu.Series["DoanhThu"].YValueMembers = "Tổng tiền";
            chartDoanhThu.Series["DoanhThu"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            connection.Close();
        }

        private void load_data_combobox(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            comboBoxNam.DataSource = table;
            comboBoxNam.ValueMember = "Năm";
            connection.Close();
        }

        private void load_data_label(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            labelSoTienTongDoanhThu.Text = table.Rows[0].ItemArray.First().ToString();
            connection.Close();
        }

        private void load_data_labelByYear(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            labelSoTienDoanhThuNam.Text = table.Rows[0].ItemArray.First().ToString();
            connection.Close();
        }

        private void FormTrangChinh_Load(object sender, EventArgs e)
        {
            load_data_combobox("SELECT YEAR(SoXeRa.thoiGianRa) 'Năm' FROM SoXeRa GROUP BY YEAR(SoXeRa.thoiGianRa) ORDER BY YEAR(SoXeRa.thoiGianRa)");
            buttonXacNhan_Click(sender, e);
            load_data_label("SELECT SUM(SoXeRa.tongTien)'total' FROM SoXeRa WHERE YEAR(SoXeRa.thoiGianRa) >= '"+ DateTime.MinValue.Year.ToString() +"' AND YEAR(SoXeRa.thoiGianRa) <= '"+ DateTime.MaxValue.Year.ToString() +"'");
            load_data_labelByYear("SELECT SUM(SoXeRa.tongTien)'total' FROM SoXeRa WHERE YEAR(SoXeRa.thoiGianRa) = '" + DateTime.Now.Year.ToString() + "'");
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            load_data_chart("SELECT MONTH(SoXeRa.thoiGianRa) 'Tháng', SUM(SoXeRa.tongTien) 'Tổng tiền' FROM SoXeRa WHERE YEAR(SoXeRa.thoiGianRa) = '" + comboBoxNam.Text.ToString() + "' GROUP BY MONTH(SoXeRa.thoiGianRa) ORDER BY MONTH(SoXeRa.thoiGianRa)");
            load_data_labelByYear("SELECT SUM(SoXeRa.tongTien)'total' FROM SoXeRa WHERE YEAR(SoXeRa.thoiGianRa) = '"+ comboBoxNam.Text.ToString() +"'");
        }
    }
}
