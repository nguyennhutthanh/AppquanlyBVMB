using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=DESKTOP-R12S0RV\SQLBOS;Initial Catalog=PLANE_TICKET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void Connect()
        {
            _con.Open();
        }

        public void Disconnect()
        {
            _con.Close();
        }
    }

    
}
