using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TinhTrangVe
    {
        private string maChuyenBay;
        private string maHangVe;
        private int tongSoGhe;
        private int soGheTrong;
        public DTO_TinhTrangVe()
        {
        }
        public DTO_TinhTrangVe(string maChuyenBay, string maHangVe, int tongSoGhe, int soGheTrong)
        {
            this.maChuyenBay = maChuyenBay;
            this.maHangVe = maHangVe;
            this.tongSoGhe = tongSoGhe;
            this.soGheTrong = soGheTrong;
        }

        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public string MaHangVe { get => maHangVe; set => maHangVe = value; }
        public int TongSoGhe { get => tongSoGhe; set => tongSoGhe = value; }
        public int SoGheTrong { get => soGheTrong; set => soGheTrong = value; }
    }
}
