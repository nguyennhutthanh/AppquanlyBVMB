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
    public class DAL_CTDoanhThuThang:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM CTDOANHTHUTHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_CTDoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO CTDOANHTHUTHANG(THANG, MACHUYENBAY, SOVEBANDUOC, DOANHTHU) VALUES('{0}', '{1}', '{2}', '{3}')", dto.Thang, dto.MaChuyenBay, dto.SoVeBanDuoc, dto.DoanhThu);
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

        public bool Update(DTO_CTDoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE CTDOANHTHUTHANG SET SOVEBANDUOC='{0}', DOANHTHU='{1}' WHERE THANG='{2}' MACHUYENBAY='{3}')", dto.SoVeBanDuoc, dto.DoanhThu, dto.Thang, dto.MaChuyenBay);
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
        public bool Delete(DTO_CTDoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM CTDOANHTHUTHANG WHERE THANG='{0}' AND MACHUYENBAY='{1}'", dto.Thang, dto.MaChuyenBay);
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
        public DataTable GetOfThangNam(string strThang, string strNam)
        {
            string sqlQuery = string.Format("SELECT* FROM CTDOANHTHUTHANG WHERE THANG='{0}' AND NAM='{1}'", strThang, strNam);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
