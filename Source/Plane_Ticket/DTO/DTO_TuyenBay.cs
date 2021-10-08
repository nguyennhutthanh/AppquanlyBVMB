using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TuyenBay
    {
        private string maTuyenBay;
        private string maSanBayDi;
        private string maSanBayDen;
        public DTO_TuyenBay()
        {
        }
        public DTO_TuyenBay(string maTuyenBay, string maSanBayDi, string maSanBayDen)
        {
            this.maTuyenBay = maTuyenBay;
            this.maSanBayDi = maSanBayDi;
            this.maSanBayDen = maSanBayDen;
        }

        public string MaTuyenBay { get => maTuyenBay; set => maTuyenBay = value; }
        public string MaSanBayDi { get => maSanBayDi; set => maSanBayDi = value; }
        public string MaSanBayDen { get => maSanBayDen; set => maSanBayDen = value; }
    }
}
