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
            
        }

 
        private void buttonThem_Click(object sender, EventArgs e)
        {
            
        }

      
       

        
        private void buttonKiemTraThe_Click(object sender, EventArgs e)
        {
                        
        }
    }
}
