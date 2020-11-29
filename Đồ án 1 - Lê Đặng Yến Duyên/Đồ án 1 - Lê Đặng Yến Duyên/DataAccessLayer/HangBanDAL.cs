using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangBan.Entities;


namespace HangBan.DataAccessLayer
{
    class HangBanDAL : IHangBanDAL
    {
        private string txtfile = "Data/Hangban.txt";
        public List<hangBan> GetAllHangBan()
        {
            List<hangBan> list = new List<hangBan>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new hangBan(a[0], int.Parse(a[1]), int.Parse(a[2])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemHangBan(hangBan hb)
        {
            string mahb = "HB" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahb + "#" + hb.sLg + "#" + hb.Gia);
            fwrite.Close();
        }
        public void Update(List<hangBan> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; i++)
                fwrite.WriteLine(list[i].maHb + "#" + list[i].sLg + "#" + list[i].Gia);
            fwrite.Close();
        }
    }
}
