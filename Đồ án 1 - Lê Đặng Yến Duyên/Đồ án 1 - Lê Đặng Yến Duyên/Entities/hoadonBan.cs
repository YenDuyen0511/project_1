using System;
using System.Collections.Generic;
using System.Text;

namespace DOAN1.Entities
{
    public class hoadonBan
    {
        private string mahdb, manv;
        private int thanhtien;
        private int ckhau;
        private DateTime ngayban;
        public string maHdb { get => mahdb; set => mahdb = value; }
        public string maNv { get => manv; set => manv = value; }
        public int thanhTien { get => thanhtien; set => thanhtien = value; }
        public int cKhau { get => ckhau; set => ckhau = value; }
        public DateTime ngayBan { get => ngayban; set => ngayban = value; }
        public hoadonBan() { }
        public hoadonBan(hoadonBan hdb)
        {
            this.mahdb = hdb.mahdb;
            this.manv = hdb.manv;
            this.thanhtien = hdb.thanhtien;
            this.ckhau = hdb.ckhau;
            this.ngayban = hdb.ngayban;
        }
        public hoadonBan(string mahdb, string manv, int thanhtien, int ckhau, DateTime ngayban)
        {
            this.mahdb = mahdb;
            this.manv = manv;
            this.thanhtien = thanhtien;
            this.ckhau = ckhau;
            this.ngayban = ngayban;
        }
    }
}
