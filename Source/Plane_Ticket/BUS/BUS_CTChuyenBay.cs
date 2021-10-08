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
    public class BUS_CTChuyenBay
    {
        DAL_CTChuyenBay dal = new DAL_CTChuyenBay();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_CTChuyenBay dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_CTChuyenBay dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_CTChuyenBay dto)
        {
            return dal.Delete(dto);
        }

        public DataTable TimSanBayTGCuaChuyenBay(string maChuyenBay)
        {
            return dal.TimSanBayTGCuaChuyenBay(maChuyenBay);
        }
        public DataTable GetForDisplayOfMaChuyenBay(string str)
        {
            return dal.GetForDisplayOfMaChuyenBay(str);
        }
    }
}
