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
    public partial class FormDangNhap : Form
    {
        SqlConnection connection;
        String connectionString = "Data Source=DESKTOP-J98APIA;Initial Catalog=BaiGiuXe;Integrated Security=True";
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private bool kiemTraTaiKhoanMatKhau(String query)
        {
            DataTable table = new DataTable();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            connection.Close();
            return false;
        }

        private bool kiemTraKiTuDacBiec(String taiKhoan, String matKhau)
        {
            bool tk = true;
            bool mk = true;
            foreach(char item in matKhau)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    mk = false;
                }
            }
            foreach (char item in taiKhoan)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    tk = false;
                }
            }
            if(mk == true && tk == true)
                return true;
            return false;
        }

        private void login(String taiKhoan, String matKhau)
        {
            if(kiemTraKiTuDacBiec(taiKhoan, matKhau))
            {
                if (kiemTraTaiKhoanMatKhau("SELECT * FROM TaiKhoan WHERE TaiKhoan.tenTaiKhoan = '"+ textBoxTaiKhoan.Text.ToString() +"' AND TaiKhoan.matKhau = '"+ textBoxMatKhau.Text.ToString() +"'"))
                {
                    FormLayoutAdmin form = new FormLayoutAdmin();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else
            {

            }
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            login(textBoxTaiKhoan.Text, textBoxMatKhau.Text);
        }
    }
}
