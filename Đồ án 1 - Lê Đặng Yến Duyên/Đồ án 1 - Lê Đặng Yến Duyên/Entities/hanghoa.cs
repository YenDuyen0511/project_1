using System;
using System.Collections.Generic;
using System.Text;

namespace HangHoa.Entities
{
    public class hanghoa
    {
        private string mahang, tenhang, maloai;
        private int slgNhap, slgCo;
        public string maHang { get => mahang; set => mahang = value; }
        public string tenHang { get => tenhang; set => tenhang = value; }
        public string maLoai { get => maloai; set => maloai = value; }
        public int slgnhap { get => slgNhap; set => slgNhap = value; }
        public int slgco { get => slgCo; set => slgCo = value; }
        public hanghoa(hanghoa hh)
        {
            this.mahang = hh.mahang;
            this.tenhang = hh.tenhang;
            this.maloai = hh.maloai;
            this.slgNhap = hh.slgNhap;
            this.slgCo = hh.slgCo;
        }
        public hanghoa(string mahang, string tenhang, string maloai, int slgNhap, int slgCo)
        {
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.maloai = maloai;
            this.slgNhap = slgNhap;
            this.slgCo = slgCo;
        }
    }
}
