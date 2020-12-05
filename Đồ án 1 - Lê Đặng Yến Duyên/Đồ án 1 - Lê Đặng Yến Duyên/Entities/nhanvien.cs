using System;
using System.Collections.Generic;
using System.Text;

namespace NhanVien.Entities
{
    public class nhanvien
    {
        private string manv, tennv, pass, loainv;
        private DateTime ngaylam;
        public string maNv { get => manv; set => manv = value; }
        public string tenNv { get => tennv; set => tennv = value; }
        public string Pass { get => pass; set => pass = value; }
        public string loaiNv { get => loainv; set => loainv = value; }
        public DateTime ngayLam { get => ngaylam; set => ngaylam = value; }
        public nhanvien() { }
        public nhanvien(nhanvien nv)
        {
            this.manv = nv.manv;
            this.tennv = nv.tennv;
            this.pass = nv.pass;
            this.loainv = nv.loainv;
            this.ngaylam = nv.ngaylam;
        }
        public nhanvien(string manv, string tennv, string pass, string loainv, DateTime ngaylam)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.pass = pass;
            this.loainv = loainv;
            this.ngaylam = ngaylam;
        }
    }
}
