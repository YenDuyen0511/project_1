using System;
using System.Collections.Generic;
using System.Text;

namespace DOAN1.Entities
{
    public class hangNhap
    {
        private string mahn;
        private int slg, dongia;
        private DateTime ngaysx, ngayhh;
        public string maHn { get => mahn; set => mahn = value; }
        public int sLg { get => slg; set => slg = value; }
        public int donGia { get => dongia; set => dongia = value; }
        public DateTime ngaySX { get => ngaysx; set => ngaysx = value; }
        public DateTime ngayHH { get => ngayhh; set => ngayhh = value; }
        public hangNhap() { }
        public hangNhap(hangNhap hn)
        {
            this.mahn = hn.mahn;
            this.slg = hn.slg;
            this.dongia = hn.dongia;
            this.ngaysx = hn.ngaysx;
            this.ngayhh = hn.ngayhh;
        }
        public hangNhap(string mahn, int slg, int dongia, DateTime ngaysx, DateTime ngayhh)
        {
            this.maHn = maHn;
            this.slg = slg;
            this.dongia = dongia;
            this.ngaysx = ngaysx;
            this.ngayhh = ngayhh;
        }
    }
}
