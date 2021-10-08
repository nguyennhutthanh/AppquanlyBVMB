using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonGia
    {
        private string maTuyenBay;
        private string maHangVe;
        private long donGia;
        public DTO_DonGia()
        {
        }
        public DTO_DonGia(string maTuyenBay, string maHangVe, long donGia)
        {
            this.MaTuyenBay = maTuyenBay;
            this.MaHangVe = maHangVe;
            this.DonGia = donGia;
        }

        public string MaTuyenBay { get => maTuyenBay; set => maTuyenBay = value; }
        public string MaHangVe { get => maHangVe; set => maHangVe = value; }
        public long DonGia { get => donGia; set => donGia = value; }
    }
}
