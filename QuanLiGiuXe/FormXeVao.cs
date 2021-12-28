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
    public partial class FormXeVao : Form
    {
        BindingSource list = new BindingSource();
        public FormXeVao()
        {
            InitializeComponent();
            dataGridViewXe.DataSource = list;
            LoadXeVao();
        }

        void LoadXeVao()
        {
            list.DataSource = SoXeVaoDAO.Instance.GetListXeVao();
        }

        private void FormXeVao_Load(object sender, EventArgs e)
        {

        }
    }
}
