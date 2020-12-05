using System;
using System.Collections.Generic;
using System.Text;

namespace TinhLuong.Entities
{
    public class tinhluong
    {
        private string matl, manv;
        private int songay;
        private double thuong, lgcb, thanhtien;
        public string maTl { get => matl; set => matl = value; }
        public string maNV { get => manv; set => manv = value; }
        public int soNgay { get => songay; set => songay = value; }
        public double Thuong { get => thuong; set => thuong = value; }
        public double lgCb { get => lgcb; set => lgcb = value; }
        public double thanhTien { get => thanhtien; set => thanhtien = value; }
        public tinhluong() { }
        public tinhluong(tinhluong tl)
        {
            this.matl = tl.matl;
            this.manv = tl.manv;
            this.songay = tl.songay;
            this.thuong = tl.thuong;
            this.lgcb = tl.lgcb;
            this.thanhtien = tl.thanhtien;
        }
        public tinhluong(string matl, string manv, int songay, double thuong, double lgcb, double thanhtien)
        {
            this.matl = matl;
            this.manv = manv;
            this.songay = songay;
            this.thuong = thuong;
            this.lgcb = lgcb;
            this.thanhtien = thanhtien;
        }
    }
}
