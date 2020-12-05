using System;
using System.Collections.Generic;
using System.Text;

namespace HoaDonNhap.Entities
{
    public class hoadonNhap
    {
        private string mahdn, tennvgiao, mancc;
        private int tong, vat;
        public string maHdn { get => mahdn; set => mahdn = value; }
        public string tenNvgiao { get => tennvgiao; set => tennvgiao = value; }
        public string maNcc { get => mancc; set => mancc = value; }
        public int Tong { get => tong; set => tong = value; }
        public int VAT { get => vat; set => vat = value; }
        public hoadonNhap() { }
        public hoadonNhap(hoadonNhap hdn)
        {
            this.mahdn = hdn.mahdn;
            this.tennvgiao = hdn.tennvgiao;
            this.mancc = hdn.mancc;
            this.tong = hdn.tong;
            this.vat = hdn.vat;
        }
        public hoadonNhap(string mahdn, string tennvgiao, string mancc, int tong, int vat)
        {
            this.mahdn = mahdn;
            this.tennvgiao = tennvgiao;
            this.mancc = mancc;
            this.tong = tong;
            this.vat = vat;
        }
    }
}
