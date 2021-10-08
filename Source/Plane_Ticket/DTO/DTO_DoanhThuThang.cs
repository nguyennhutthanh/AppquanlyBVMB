using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DoanhThuThang
    {
        private string thang;
        private string nam;
        private int soChuyenBay;
        private long doanhThu;

        public DTO_DoanhThuThang()
        {
        }

        public DTO_DoanhThuThang(string thang, string nam, int soChuyenBay, long doanhThu)
        {
            this.Thang = thang;
            this.Nam = nam;
            this.SoChuyenBay = soChuyenBay;
            this.DoanhThu = doanhThu;
        }

        public string Thang { get => thang; set => thang = value; }
        public string Nam { get => nam; set => nam = value; }
        public int SoChuyenBay { get => soChuyenBay; set => soChuyenBay = value; }
        public long DoanhThu { get => doanhThu; set => doanhThu = value; }
    }
}
