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
    public class BUS_DoanhThuThang
    {
        DAL_DoanhThuThang dal = new DAL_DoanhThuThang();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_DoanhThuThang dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_DoanhThuThang dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_DoanhThuThang dto)
        {
            return dal.Delete(dto);
        }
        public DataTable GetOfNam(string strNam)
        {
            return dal.GetOfNam(strNam);
        }
       
    }
}
