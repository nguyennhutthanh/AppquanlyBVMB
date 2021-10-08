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
    public class DAL_KhachHang:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT MAKHACHHANG[Mã khách hàng], TENKHACHHANG[Tên khách hàng], " +
                "CMND[CMND], SDT[Số điện thoại] FROM KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Add(DTO_KhachHang dto)
        {
            try
            {
                _con.Open();
                string maKhachHang = TaoMaKhachHang();
                string sqlQuery = string.Format("INSERT INTO KHACHHANG(MAKHACHHANG, TENKHACHHANG, CMND, SDT) VALUES('{0}', N'{1}', '{2}', '{3}')", maKhachHang, dto.TenKhachHang, dto.CMND1, dto.SDT1);
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

        public bool Update(DTO_KhachHang dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE KHACHHANG SET TENKHACHHANG=N'{0}', CMND='{1}', SDT='{2}' WHERE MAKHACHHANG='{3}'", dto.TenKhachHang, dto.CMND1, dto.SDT1, dto.MaKhachHang);
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
                string sqlQuery = string.Format("DELETE FROM KHACHHANG WHERE MAKHACHHANG='{0}'", str);
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
        public DataTable GetOfCMND(string CMND)
        {
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT * FROM KHACHHANG WHERE CMND='{0}'", CMND);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            da.Fill(dt);
            return dt;
        }
        public DataTable GetAndSortDesc()
        {
            string sqlQuery = "SELECT * FROM KHACHHANG ORDER BY MAKHACHHANG DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private string TaoMaKhachHang()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "KH000" + dt.Rows.Count;
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
            return "KH" + strSoKhong + count;
        }
        public DataTable SearchOfMaKhachHang(string str)
        {
            string sqlQuery = string.Format("SELECT MAKHACHHANG[Mã khách hàng], TENKHACHHANG[Tên khách hàng], " +
                "CMND[CMND], SDT[Số điện thoại] FROM KHACHHANG " +
                "WHERE MAKHACHHANG LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
