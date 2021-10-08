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
    public class DAL_DoanhThuThang:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM DOANHTHUTHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Add(DTO_DoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO DOANHTHUTHANG(THANG, NAM, SOCHUYENBAY, DOANHTHU) VALUES('{0}', '{1}', '{2}', '{3}')", dto.Thang, dto.Nam, dto.SoChuyenBay, dto.DoanhThu);
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
        public bool Update(DTO_DoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE DOANHTHUTHANG SET SOCHUYENBAY='{0}', DOANHTHU='{1}' WHERE THANG='{2}' AND NAM='{3}')", dto.SoChuyenBay, dto.DoanhThu, dto.Thang, dto.Nam);
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
        public bool Delete(DTO_DoanhThuThang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM DOANHTHUTHANG WHERE THANG='{0}' AND NAM='{1}'", dto.Thang, dto.Nam);
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
        public DataTable GetOfNam(string strNam)
        {
            string sqlQuery = string.Format("SELECT* FROM DOANHTHUTHANG WHERE NAM='{0}'", strNam);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       
    }
}
