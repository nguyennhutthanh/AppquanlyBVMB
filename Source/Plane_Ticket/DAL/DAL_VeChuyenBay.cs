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
	public class DAL_VeChuyenBay : DBConnect
	{
		public DataTable Get()
		{
			string sqlQuery = "SELECT* FROM VECHUYENBAY";
			SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}
		public DataTable GetForDisplay()
		{
			string sqlQuery = "SELECT V.MAVE[Mã vé], K.TENKHACHHANG[Tên khách hàng], " +
				"K.CMND[CMND], V.MACHUYENBAY[Mã chuyến bay], H.TENHANGVE[Tên hạng vé], " +
				"V.GIATIEN[Giá tiền], V.NGAYGIOGD[Ngày giờ giao dịch], V.NGAYHUY[Ngày hủy], " +
				"V.LOAIVE[Loại vé] FROM VECHUYENBAY V INNER JOIN KHACHHANG K " +
				"ON V.MAKHACHHANG=K.MAKHACHHANG INNER JOIN HANGVE H ON V.MAHANGVE=H.MAHANGVE";
			SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}
		public bool Add(DTO_VeChuyenBay dto)
		{
			try
			{
				_con.Open();
				string maVe = TaoMaVe();
				string sqlQuery = string.Format("INSERT INTO VECHUYENBAY(MAVE, MAKHACHHANG, " +
					"MACHUYENBAY, MAHANGVE, MANHANVIEN, GIATIEN, NGAYGIOGD, LOAIVE) " +
					"VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', N'{7}')"
					, maVe, dto.MaKhachHang, dto.MaChuyenBay, dto.MaHangVe, dto.MaNhanVien,
					dto.GiaTien, dto.NgayGioGD, dto.LoaiVe);
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
		public bool Update(DTO_VeChuyenBay dto)
		{
			try
			{
				_con.Open();
				string sqlQuery = string.Format("UPDATE VECHUYENBAY SET MAKHACHHANG='{0}', MACHUYENBAY='{1}', MAHANGVE='{2}', MANHANVIEN='{3}', GIATIEN='{4}', NGAYGIOGD='{5}', LOAIVE=N'{6}' WHERE MAVE='{7}')"
					, dto.MaKhachHang, dto.MaChuyenBay, dto.MaHangVe, dto.MaNhanVien,
					dto.GiaTien, dto.NgayGioGD, dto.LoaiVe, dto.MaVe);
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
		public bool Delete(string maVe)
		{
			try
			{
				_con.Open();
				string sqlQuery = string.Format("DELETE FROM VECHUYENBAY WHERE MAVE='{0}'", maVe);
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
		public DataTable GetSumBill(string MAKH)
		{
			string sqlQuery = string.Format("SELECT V.MAVE, K.TENKHACHHANG,K.CMND," +
				"H.TENHANGVE, V.GIATIEN, V.NGAYGIOGD," +
				"V.NGAYHUY, V.LOAIVE, C.THOIGIANKHOIHANH, C.MACHUYENBAY," +
				"C.THOIGIANBAY, N.TENNHANVIEN, K.SDT ,M.TENMAYBAY" +
				" FROM CHUYENBAY C INNER JOIN" +
				" MAYBAY M ON C.MAMAYBAY = M.MAMAYBAY INNER JOIN " +
				" VECHUYENBAY V ON C.MACHUYENBAY = V.MACHUYENBAY INNER JOIN " +
				" KHACHHANG K ON V.MAKHACHHANG = K.MAKHACHHANG INNER JOIN " +
				" HANGVE H ON V.MAHANGVE = H.MAHANGVE INNER JOIN " +
				" NHANVIEN N ON V.MANHANVIEN = N.MANHANVIEN " +
				" WHERE V.MAVE Like '%{0}%'", MAKH);
			SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}
		public DataTable GetAndSortDesc()
		{
			string sqlQuery = "SELECT * FROM VECHUYENBAY ORDER BY MAVE DESC";
			SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}
		public DataTable ResreachMave(string mave)
		{
			string sqlQuery = string.Format("SELECT V.MAVE[Mã vé], K.TENKHACHHANG[Tên khách hàng], " +
				" K.CMND[CMND], V.MACHUYENBAY[Mã chuyến bay], H.TENHANGVE[Tên hạng vé], " +
				" V.GIATIEN[Giá tiền], V.NGAYGIOGD[Ngày giờ giao dịch], V.NGAYHUY[Ngày hủy], " +
				" V.LOAIVE[Loại vé] FROM VECHUYENBAY V INNER JOIN KHACHHANG K " +
				" ON V.MAKHACHHANG=K.MAKHACHHANG INNER JOIN HANGVE H ON V.MAHANGVE=H.MAHANGVE " +
				" WHERE V.MAVE LIKE '%{0}%'", mave);
			SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}
		private string TaoMaVe()
		{
			DataTable dt = this.GetAndSortDesc();
			if (dt.Rows.Count == 0)
				return "VE000" + dt.Rows.Count;
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
			return "VE" + strSoKhong + count;
		}
	}
}
