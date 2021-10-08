using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class BUS_ChuyenBay
    {
        DAL_ChuyenBay dal = new DAL_ChuyenBay();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_ChuyenBay dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_ChuyenBay dto)
        {
            return dal.Update(dto);
        }
        public bool Delete(string str)
        {
            return dal.Delete(str);
        }
        public DataTable GetOfMaChuyenBay(string maChuyenBay)
        {
            return dal.GetOfMaChuyenBay(maChuyenBay);
        }
        public DateTime GetDateTimeOfMaChuyenBay(string str)
        {
            return dal.GetDateTimeOfMaChuyenBay(str);
        }
        public DataTable GetToDisplay()
        {
            return dal.GetToDisplay();
        }
        public DataTable SearchOfMaChuyenBay(string str)
        {
            return dal.SearchOfMaChuyenBay(str);
        }
        public DataTable Search(string maSanBayDi, string maSanBayDen, DateTime ngayKHTu, DateTime ngayKHDen)
        {
            return dal.Search(maSanBayDi, maSanBayDen, ngayKHTu, ngayKHDen);
        }
    }
}
