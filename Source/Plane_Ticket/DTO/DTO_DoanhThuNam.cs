using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DoanhThuNam
    {
        private string nam;
        private long doanhThu;
        public DTO_DoanhThuNam()
        {
        }

        public DTO_DoanhThuNam(string nam, long doanhThu)
        {
            this.Nam = nam;
            this.DoanhThu = doanhThu;
        }

        public string Nam { get => nam; set => nam = value; }
        public long DoanhThu { get => doanhThu; set => doanhThu = value; }
    }
}
