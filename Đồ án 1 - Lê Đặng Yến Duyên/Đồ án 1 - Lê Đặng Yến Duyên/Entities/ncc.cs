using System;
using System.Collections.Generic;
using System.Text;

namespace DOAN1.Entities
{
    public class ncc
    {
        private string mancc, tenncc, dchi, sdt;
        public string maNcc { get => mancc; set => mancc = value; }
        public string tenNcc { get => tenncc; set => tenncc= value; }
        public string dChi { get => dchi; set => dchi = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public ncc() { }
        public ncc(ncc cc)
        {
            this.mancc = cc.mancc;
            this.tenncc = cc.tenncc;
            this.dchi = cc.dchi;
            this.sdt = cc.sdt;
        }
        public ncc(string mancc, string tenncc, string dchi, string sdt)
        {
            this.mancc = mancc;
            this.tenncc = tenncc;
            this.dchi = dchi;
            this.sdt = sdt;
        }
    }
}
