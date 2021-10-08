using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TuyenBay
    {
        DAL_TuyenBay dal = new DAL_TuyenBay();

        public DataTable Get()
        {
            return dal.Get();
        }
        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }
        public DataTable GetForDSTuyenBay()
        {
            return dal.GetForDSTuyenBay();        }
        public bool Add(DTO_TuyenBay dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_TuyenBay dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(string str)
        {
            return dal.Delete(str);
        }

        public DataTable SearchOfMaTuyenBay(string maTuyenBay)
        {
            return dal.SearchOfMaTuyenBay(maTuyenBay);
        }
        public DataTable GetOfMaTuyenBay(string str)
        {
            return dal.GetOfMaTuyenBay(str);
        }
        public DataTable GetOfMaSanBay(string maSBDi, string maSBDen)
        {
            return dal.GetOfMaSanBay(maSBDi, maSBDen);
        }
    }
}
