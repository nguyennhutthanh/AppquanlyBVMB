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
    public class DAL_DonGia:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM DONGIA";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT MATUYENBAY[Mã tuyến bay], MAHANGVE[Mã hạng vé], DONGIA[Đơn giá] FROM DONGIA";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Add(DTO_DonGia dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO DONGIA(MATUYENBAY, MAHANGVE, DONGIA) VALUES('{0}', '{1}', '{2}')", dto.MaTuyenBay, dto.MaHangVe, dto.DonGia);
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
        public bool Update(DTO_DonGia dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE DONGIA SET DONGIA='{0}' " +
                    "WHERE MATUYENBAY='{1}' AND MAHANGVE='{2}'", dto.DonGia, dto.MaTuyenBay, dto.MaHangVe);
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
        public bool Delete(DTO_DonGia dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM DONGIA WHERE MAHANGVE='{0}' AND MATUYENBAY='{1}'", dto.MaHangVe, dto.MaTuyenBay);
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
        public DataTable SearchOfMaTuyenBayAndMaHangVe(string maTuyenBay, string maHangVe)
        {
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT * FROM DONGIA WHERE MATUYENBAY='{0}' AND MAHANGVE='{1}'", maTuyenBay, maHangVe);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            da.Fill(dt);
            return dt;
        }
    }
}
