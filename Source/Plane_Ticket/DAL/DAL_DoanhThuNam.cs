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
	public class DAL_DoanhThuNam : DBConnect
	{
		public DataTable Get()
		{
			string sqlQuery = "SELECT* FROM DOANHTHUNAM";
			SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}

		public bool Add(DTO_DoanhThuNam dto)
		{
			try
			{
				_con.Open();
				string sqlQuery = string.Format("INSERT INTO DOANHTHUNAM(NAM, DOANHTHU) VALUES('{0}', '{1}')", dto.Nam, dto.DoanhThu);
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
		public bool Update(DTO_DoanhThuNam dto)
		{
			try
			{
				_con.Open();
				string sqlQuery = string.Format("UPDATE DOANHTHUNAM SET DOANHTHU='{0}' WHERE NAM='{1}')", dto.DoanhThu, dto.Nam);
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
		public bool Delete(DTO_DoanhThuNam dto)
		{
			try
			{
				_con.Open();
				string sqlQuery = string.Format("DELETE FROM DOANHTHUNAM WHERE NAM='{0}'", dto.Nam);
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
		public DataTable GetOfNam(string str)
		{
			string sqlQuery = string.Format("SELECT* FROM DOANHTHUNAM WHERE NAM='{0}'", str);
			SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
			DataTable dt = new DataTable();
			da.Fill(dt);
			return dt;
		}
	}
}
