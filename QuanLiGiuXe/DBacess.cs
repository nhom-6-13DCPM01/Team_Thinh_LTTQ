using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGiuXe
{
    class DBacess
    {
        public SqlConnection Getcon()
        {
            return new SqlConnection(@"Data Source=DESKTOP-G00H53A\SQLEXPRESS;Initial Catalog=BaiGiuXe;Integrated Security=True");

        }
    }
}
