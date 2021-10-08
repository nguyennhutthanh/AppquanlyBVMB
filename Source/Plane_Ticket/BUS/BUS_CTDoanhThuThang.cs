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
    public class BUS_CTDoanhThuThang
    {
        DAL_CTDoanhThuThang dal = new DAL_CTDoanhThuThang();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_CTDoanhThuThang dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_CTDoanhThuThang dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_CTDoanhThuThang dto)
        {
            return dal.Delete(dto);
        }
        public DataTable GetOfThangNam(string strThang, string strNam)
        {
            return dal.GetOfThangNam(strThang, strNam);
        }
    }
}
