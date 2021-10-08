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
    public class BUS_DoanhThuNam
    {
        DAL_DoanhThuNam dal = new DAL_DoanhThuNam();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_DoanhThuNam dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_DoanhThuNam dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(DTO_DoanhThuNam dto)
        {
            return dal.Delete(dto);
        }

        public DataTable GetOfNam(string str)
        {
            return dal.GetOfNam(str);
        }
    }
}
