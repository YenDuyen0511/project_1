using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1.Entities
{
    public class loaihang
    {
        private string maloai, tenloai, mausac;
        public string maLoai { get => maloai; set => maloai = value; }
        public string tenLoai { get => tenloai; set => tenloai = value; }
        public string mauSac { get => mausac; set => mausac = value; }
        public loaihang() { }
        public loaihang(loaihang lh)
        {
            this.maloai = lh.maloai;
            this.tenloai = lh.tenloai;
            this.mausac = lh.mausac;
        }
        public loaihang(string maloai, string tenloai, string mausac)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
            this.mausac = mausac;
        }
    }
}
