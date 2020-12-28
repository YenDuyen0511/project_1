using System;
using System.Collections.Generic;
using System.Text;

namespace DOAN1.Entities
{
    public class giaban
    {
        private string mahang, dvi;
        private int gia;
        private DateTime ngayAD, ngayKT;
        public string maHang { get => mahang; set => mahang = value; }
        public string donvi { get => dvi; set => dvi = value; }
        public int Gia { get => gia; set => gia = value; }
        public DateTime ngayad { get => ngayAD; set => ngayAD = value; }
        public DateTime ngaykt { get => ngayKT; set => ngayKT = value; }
        public giaban() { }
        public giaban(giaban gb)
        {
            this.mahang = gb.mahang;
            this.dvi = gb.dvi;
            this.gia = gb.gia;
            this.ngayAD = gb.ngayAD;
            this.ngayKT = gb.ngayKT;
        }
        public giaban(string mahang, string dvi, int gia, DateTime ngayAD, DateTime ngayKT)
        {
            this.mahang = mahang;
            this.dvi = dvi;
            this.gia = gia;
            this.ngayAD = ngayAD;
            this.ngayKT = ngayKT;
        }
    }
}
