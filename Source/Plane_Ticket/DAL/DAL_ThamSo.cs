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
    public class DAL_ThamSo:DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM THAMSO";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT THOIGIANBAYTOITHIEU[Thời gian bay tối thiểu], SOSANBAYTGTOIDA[Số sân bay TG tối đa],THOIGIANDUNGTOITHIEU[Thời gian dừng tối thiểu],THOIGIANDUNGTOIDA[Thời gian dừng tối đa],TGCHAMNHATDATVE[Thời gian chậm nhất đặt vé],TGCHAMNHATHUYDATVE[Thời gian chậm nhất đặt vé] FROM THAMSO";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Add(DTO_ThamSo dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO THAMSO(THOIGIANBAYTOITHIEU, SOSANBAYTGTOIDA,THOIGIANDUNGTOITHIEU,THOIGIANDUNGTOIDA,TGCHAMNHATDATVE,TGCHAMNHATHUYDATVE) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", dto.ThoiGianDungToiThieu, dto.SoSanBayTGToiDa, dto.ThoiGianDungToiThieu, dto.ThoiGianDungToiDa, dto.ThoiGianChamNhatDatVe, dto.ThoiGianChamNhatHuyVe);
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

        public bool Update(DTO_ThamSo dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE THAMSO SET THOIGIANBAYTOITHIEU='{0}', SOSANBAYTGTOIDA='{1}', THOIGIANDUNGTOITHIEU='{2}', THOIGIANDUNGTOIDA='{3}', TGCHAMNHATDATVE='{4}', TGCHAMNHATHUYDATVE='{5}' ", dto.ThoiGianBayToiThieu, dto.SoSanBayTGToiDa, dto.ThoiGianDungToiThieu, dto.ThoiGianDungToiDa, dto.ThoiGianChamNhatDatVe, dto.ThoiGianChamNhatHuyVe);
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
        
    }
}
