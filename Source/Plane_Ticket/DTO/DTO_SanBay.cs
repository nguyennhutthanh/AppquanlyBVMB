using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanBay
    {
        private string maSanBay;
        private string tenSanBay;
        private string tenThanhPho;

        public DTO_SanBay()
        {
        }

        public DTO_SanBay(string maSanBay, string tenSanBay, string tenThanhPho)
        {
            this.maSanBay = maSanBay;
            this.tenSanBay = tenSanBay;
            this.tenThanhPho = tenThanhPho;
        }

        public string MaSanBay { get => maSanBay; set => maSanBay = value; }
        public string TenSanBay { get => tenSanBay; set => tenSanBay = value; }
        public string TenThanhPho { get => tenThanhPho; set => tenThanhPho = value; }
    }
}
