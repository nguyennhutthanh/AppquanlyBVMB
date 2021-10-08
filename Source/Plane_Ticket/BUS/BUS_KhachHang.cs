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
    public class BUS_KhachHang
    {
        DAL_KhachHang dal = new DAL_KhachHang();

        public DataTable Get()
        {
            return dal.Get();
        }
        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }
        public bool Add(DTO_KhachHang dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_KhachHang dto)
        {
            return dal.Update(dto);
        }
        public bool Delete(string str)
        {
            return dal.Delete(str);
        }
        public DataTable GetOfCMND(string maKhachHang)
        {
            return dal.GetOfCMND(maKhachHang);
        }
        public DataTable SearchOfMaKhachHang(string str)
        {
            return dal.SearchOfMaKhachHang(str);
        }
    }
}
