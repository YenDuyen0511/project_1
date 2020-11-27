using System;
using System.Collections.Generic;
using System.Text;

namespace HangBan.Entities
{
    public class hangBan
    {
        private string mahb;
        private int slg, gia;
        public string maHb { get => mahb; set => mahb = value; }
        public int sLg { get => slg; set => slg = value; }
        public int Gia { get => gia; set => gia = value; }
        public hangBan(hangBan hb)
        {
            this.mahb = hb.mahb;
            this.slg = hb.slg;
            this.gia = hb.gia;
        }
        public hangBan(string mahb, int slg, int gia)
        {
            this.mahb = mahb;
            this.slg = slg;
            this.gia = gia;
        }
    }
}
