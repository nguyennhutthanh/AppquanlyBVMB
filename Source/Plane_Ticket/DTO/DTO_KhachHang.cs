using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string CMND;
        private string SDT;

        public DTO_KhachHang()
        {

        }

        public DTO_KhachHang(string maKhachHang, string tenKhachHang, string CMND, string SDT)
        {
            this.maKhachHang = maKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.CMND = CMND;
            this.SDT = SDT;
        }

      
        public string CMND1 { get => CMND; set => CMND = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
    }
}
