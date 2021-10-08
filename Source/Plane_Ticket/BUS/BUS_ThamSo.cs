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
    public class BUS_ThamSo
    {
        DAL_ThamSo dal = new DAL_ThamSo();

        public DataTable Get()
        {
            return dal.Get();
        }
        public bool Add(DTO_ThamSo dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_ThamSo dto)
        {
            return dal.Update(dto);
        }
        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }

    }
}
