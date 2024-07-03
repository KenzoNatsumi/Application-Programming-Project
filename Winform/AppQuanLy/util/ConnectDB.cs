using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lí_cửa_hàng_máy_tính.util
{
    internal class ConnectDB
    {
        SqlConnection connect;
        public ConnectDB()
        {
            connect = null;
        }
        public SqlConnection getConnection()
        {
            if (connect == null)
            {
                connect = new SqlConnection("Data Source=KENZO\\SQLEXPRESS;" +
                    " Initial Catalog = QLBANHANGDIENLANH; Integrated Security = True");
                if (connect.State == System.Data.ConnectionState.Closed)
                {
                    connect.Open();
                }
            }
            return connect;
        }
    }
}
