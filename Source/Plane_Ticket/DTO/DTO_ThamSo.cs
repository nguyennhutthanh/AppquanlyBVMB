using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThamSo
    {
        private float thoiGianBayToiThieu;
        private int soSanBayTGToiDa;
        private float thoiGianDungToiThieu;
        private float thoiGianDungToiDa;
        private float thoiGianChamNhatDatVe;
        private float thoiGianChamNhatHuyVe;
        public DTO_ThamSo()
        {
        }

        public DTO_ThamSo(float thoiGianBayToiThieu, int soSanBayTGToiDa, float thoiGianDungToiThieu, float thoiGianDungToiDa, float thoiGianChamNhatDatVe, float thoiGianChamNhatHuyVe)
        {
            this.ThoiGianBayToiThieu = thoiGianBayToiThieu;
            this.SoSanBayTGToiDa = soSanBayTGToiDa;
            this.ThoiGianDungToiThieu = thoiGianDungToiThieu;
            this.ThoiGianDungToiDa = thoiGianDungToiDa;
            this.ThoiGianChamNhatDatVe = thoiGianChamNhatDatVe;
            this.ThoiGianChamNhatHuyVe = thoiGianChamNhatHuyVe;
        }

        public float ThoiGianBayToiThieu { get => thoiGianBayToiThieu; set => thoiGianBayToiThieu = value; }
        public int SoSanBayTGToiDa { get => soSanBayTGToiDa; set => soSanBayTGToiDa = value; }
        public float ThoiGianDungToiThieu { get => thoiGianDungToiThieu; set => thoiGianDungToiThieu = value; }
        public float ThoiGianDungToiDa { get => thoiGianDungToiDa; set => thoiGianDungToiDa = value; }
        public float ThoiGianChamNhatDatVe { get => thoiGianChamNhatDatVe; set => thoiGianChamNhatDatVe = value; }
        public float ThoiGianChamNhatHuyVe { get => thoiGianChamNhatHuyVe; set => thoiGianChamNhatHuyVe = value; }
    }
}
