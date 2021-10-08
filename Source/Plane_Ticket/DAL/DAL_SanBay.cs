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
    public class DAL_SanBay:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT * FROM SANBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT MASANBAY[Mã sân bay], TENSANBAY[Tên sân bay], " +
                "TENTHANHPHO[Tên Thành Phố] FROM SANBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Add(DTO_SanBay dto)
        {
            try
            {
                _con.Open();
                string maSanBay = TaoMaSanBay();
                string sqlQuery = string.Format("INSERT INTO SANBAY(MASANBAY, TENSANBAY, TENTHANHPHO) VALUES('{0}', N'{1}', N'{2}')", maSanBay, dto.TenSanBay, dto.TenThanhPho);
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

        public DataTable SearchOfMaSanBay(string maSanBay)
        {
            string sqlQuery = string.Format("SELECT MASANBAY[Mã sân bay], TENSANBAY[Tên sân bay], " +
                "TENTHANHPHO[Tên Thành Phố] FROM SANBAY WHERE MASANBAY LIKE('%{0}%')", maSanBay);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Update(DTO_SanBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE SANBAY SET TENSANBAY=N'{0}', TENTHANHPHO=N'{1}' WHERE MASANBAY='{2}'", dto.TenSanBay, dto.TenThanhPho, dto.MaSanBay);
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
        public bool Delete(string maSanBay)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM SANBAY WHERE MASANBAY='{0}'",maSanBay);
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
            string sqlQuery = "SELECT MASANBAY[Mã sân bay], TENSANBAY[Tên sân bay], " +
                "TENTHANHPHO[Tên Thành Phố] FROM SANBAY ORDER BY MASANBAY DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private string TaoMaSanBay()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "SB000" + dt.Rows.Count;
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
            return "SB" + strSoKhong + count;
        }
        public bool CheckSanBay(string tenSanBay, string tenThanhPho)
        {
            string sqlQuery = string.Format("SELECT * FROM SANBAY WHERE TENSANBAY =N'{0}' AND TENTHANHPHO=N'{1}'", tenSanBay, tenThanhPho);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
