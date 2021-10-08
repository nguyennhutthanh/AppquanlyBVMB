using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MayBay:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT * FROM MAYBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT MAMAYBAY[Mã máy bay], TENMAYBAY[Tên máy bay], " +
                "SOLUONGGHE[Số lượng ghế] FROM MAYBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_MayBay dto)
        {
            try
            {
                _con.Open();
                string maMayBay = TaoMaMayBay();
                string sqlQuery = string.Format("INSERT INTO MAYBAY(TENMAYBAY, SOLUONGGHE, MAMAYBAY) VALUES('{0}', '{1}', '{2}')", dto.TenMayBay, dto.SoLuongGhe, maMayBay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public bool Update(DTO_MayBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE MAYBAY SET TENMAYBAY='{0}', SOLUONGGHE='{1}' WHERE MAMAYBAY='{2}'", dto.TenMayBay, dto.SoLuongGhe, dto.MaMayBay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public bool Delete(string str)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM MAYBAY WHERE MAMAYBAY='{0}'", str);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public DataTable GetAndSortDesc()
        {
            string sqlQuery = "SELECT * FROM MAYBAY ORDER BY MAMAYBAY DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private string TaoMaMayBay()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "MB000" + dt.Rows.Count;
            DataRow row = dt.Rows[0];
            string maTuyenBay = row[0].ToString().Substring(2);
            int count = int.Parse(maTuyenBay) + 1;
            int temp = count;
            string strSoKhong = "";
            int dem = 0;
            while (temp > 0)
            {
                temp /= 10;
                dem++;
            }
            for (int i = 0; i < 4 - dem; i++)
            {
                strSoKhong += "0";
            }
            return "MB" + strSoKhong + count;
        }
        public DataTable SearchOfMaMayBay(string str)
        {
            string sqlQuery = string.Format("SELECT MAMAYBAY[Mã máy bay], TENMAYBAY[Tên máy bay], " +
                "SOLUONGGHE[Số lượng ghế] FROM MAYBAY WHERE MAMAYBAY LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
