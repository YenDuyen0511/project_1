using System;
using System.Collections.Generic;
using System.Text;

namespace HoaDonBan.Entities
{
    public class hoadonBan
    {
        private string mahdb, manv;
        private int thanhtien, ckhau;
        public string maHdb { get => mahdb; set => mahdb = value; }
        private string maNv { get => manv; set => manv = value; }
        private int thanhTien { get => thanhTien; set => thanhTien = value; }
        private int cKhau { get => ckhau; set => ckhau = value; }
        public hoadonBan(hoadonBan hdb)
        {
            this.mahdb = hdb.mahdb;
            this.manv = hdb.manv;
            this.thanhTien = hdb.thanhTien;
            this.ckhau = hdb.ckhau;
        }
        public hoadonBan(string mahdb, string manv, int thanhtien, int ckhau)
        {
            this.mahdb = mahdb;
            this.manv = manv;
            this.thanhTien = thanhTien;
            this.ckhau = ckhau;
        }
    }
}
