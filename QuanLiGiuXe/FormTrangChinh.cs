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
    public partial class FormTrangChinh : Form
    {
        public FormTrangChinh()
        {
            InitializeComponent();
        }

        private void FormTrangChinh_Load(object sender, EventArgs e)
        {
            labelTenTeam.Text = " BÃI GIỮ XE " + "\n" + "THỊNH VIỆT";
        }
    }
}
