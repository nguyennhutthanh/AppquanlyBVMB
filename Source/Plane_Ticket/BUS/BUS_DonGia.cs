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
    public class BUS_DonGia
    {
        DAL_DonGia dal = new DAL_DonGia();

        public DataTable Get()
        {
            return dal.Get();
        }
        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }
        public bool Add(DTO_DonGia dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_DonGia dto)
        {
            return dal.Update(dto);
        }
        public bool Delete(DTO_DonGia dto)
        {
            return dal.Delete(dto);
        }
        public DataTable SearchOfMaTuyenBayAndMaHangVe(string maTuyenBay, string maHangVe)
        {
            return dal.SearchOfMaTuyenBayAndMaHangVe(maTuyenBay, maHangVe);
        }
    }
}
