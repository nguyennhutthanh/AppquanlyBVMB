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
    public class BUS_VeChuyenBay
    {
        DAL_VeChuyenBay dal = new DAL_VeChuyenBay();

        public DataTable Get()
        {
            return dal.Get();
        }
        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }
        public bool Add(DTO_VeChuyenBay dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_VeChuyenBay dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(string str)
        {
            return dal.Delete(str);
        }
        public DataTable ResreachMave(string mave)
        {
            return dal.ResreachMave(mave);
        }
        public DataTable GetSumBill(string MAKH)
		{
            return dal.GetSumBill(MAKH);
		}
    }
}
