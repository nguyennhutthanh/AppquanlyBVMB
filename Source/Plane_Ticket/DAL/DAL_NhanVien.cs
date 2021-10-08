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
    public class DAL_NhanVien:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT * FROM NHANVIEN N INNER JOIN ACCOUNT A ON N.MANHANVIEN=A.MANHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT N.MANHANVIEN[Mã nhân viên], N.TENNHANVIEN[Tên nhân viên], " +
                "A.USERNAME[Username], A.PASSWORD[Password], A.TYPE[Loại nhân viên] " +
                "FROM NHANVIEN N INNER JOIN ACCOUNT A ON N.MANHANVIEN=A.MANHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Add(DTO_NhanVien dto)
        {
            try
            {
                _con.Open();
                string maNhanVien = TaoMaNhanVien();
                string sqlQuery1 = string.Format("INSERT INTO NHANVIEN(MANHANVIEN, TENNHANVIEN) VALUES('{0}', N'{1}')", maNhanVien, dto.TenNhanVien);
                SqlCommand cmd1 = new SqlCommand(sqlQuery1, _con);
                string sqlQuery2 = string.Format("INSERT INTO ACCOUNT(USERNAME, PASSWORD, MANHANVIEN, TYPE) VALUES('{0}', '{1}', '{2}','{3}')", dto.Username, dto.Password, maNhanVien, dto.Type);
                SqlCommand cmd2 = new SqlCommand(sqlQuery2, _con);
                if (cmd1.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0)
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
        public bool Update(DTO_NhanVien dto)
        {
            try
            {
                _con.Open();
                string sqlQuery1 = string.Format("UPDATE NHANVIEN SET TENNHANVIEN=N'{0}'WHERE MANHANVIEN='{1}'", dto.TenNhanVien, dto.MaNhanVien);
                SqlCommand cmd1 = new SqlCommand(sqlQuery1, _con);
                string sqlQuery2 = string.Format("UPDATE ACCOUNT SET USERNAME='{0}', PASSWORD='{1}', TYPE='{2}' WHERE MANHANVIEN='{3}'", dto.Username, dto.Password, dto.Type, dto.MaNhanVien);
                SqlCommand cmd2 = new SqlCommand(sqlQuery2, _con);
                if (cmd1.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0)
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
        public bool Delete(string str)
        {
            try
            {
                _con.Open();
                string sqlQuery1 = string.Format("DELETE FROM NHANVIEN WHERE MANHANVIEN='{0}'", str);
                SqlCommand cmd1 = new SqlCommand(sqlQuery1, _con);
                string sqlQuery2 = string.Format("DELETE FROM ACCOUNT WHERE MANHANVIEN='{0}'", str);
                SqlCommand cmd2 = new SqlCommand(sqlQuery2, _con);
                if (cmd2.ExecuteNonQuery() > 0 && cmd1.ExecuteNonQuery() > 0)
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
        public DataTable SearchOfMaNhanVien(string str)
        {
            string sqlQuery = string.Format("SELECT N.MANHANVIEN[Mã nhân viên], N.TENNHANVIEN[Tên nhân viên], " +
                "A.USERNAME[Username], A.PASSWORD[Password], A.TYPE[Loại nhân viên] " +
                "FROM NHANVIEN N INNER JOIN ACCOUNT A ON N.MANHANVIEN=A.MANHANVIEN " +
                "WHERE MANHANVIEN LIKE '%{0}%'", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetAndSortDesc()
        {
            string sqlQuery = "SELECT * FROM NHANVIEN ORDER BY MANHANVIEN DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private string TaoMaNhanVien()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "NV000" + dt.Rows.Count;
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
            return "NV" + strSoKhong + count;
        }
        public DataTable GetOfUsernameAndPassword(string username, string password)
        {
            string sqlQuery = string.Format("SELECT * FROM ACCOUNT WHERE USERNAME='{0}' AND PASSWORD='{1}'",username,password);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
