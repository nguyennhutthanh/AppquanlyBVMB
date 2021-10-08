using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTChuyenBay
    {
        private string maChuyenBay;
        private string maSanBayTG;
        private float thoiGianDung;
        private string ghiChu;

        public DTO_CTChuyenBay()
        {
        }

        public DTO_CTChuyenBay(string maChuyenBay, string maSanBayTG, float thoiGianDung, string ghiChu)
        {
            this.MaChuyenBay = maChuyenBay;
            this.MaSanBayTG = maSanBayTG;
            this.ThoiGianDung = thoiGianDung;
            this.GhiChu = ghiChu;
        }

        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public string MaSanBayTG { get => maSanBayTG; set => maSanBayTG = value; }
        public float ThoiGianDung { get => thoiGianDung; set => thoiGianDung = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
