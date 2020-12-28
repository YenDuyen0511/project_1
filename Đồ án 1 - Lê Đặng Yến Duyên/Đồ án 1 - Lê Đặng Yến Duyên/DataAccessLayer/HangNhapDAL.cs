using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    class HangNhapDAL : IHangNhapDAL
    {
        private string txtfile = "Data/Hangnhap.txt";
        public List<hangNhap> GetAllHangnhap()
        {
            List<hangNhap> list = new List<hangNhap>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new hangNhap(a[0], int.Parse(a[1]), int.Parse(a[2]), DateTime.Parse(a[3]), DateTime.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemHangnhap(hangNhap hn)
        {
            string mahn = "HN" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahn + "#" + hn.sLg + "#" + hn.donGia + "#" + hn.ngaySX + "#" + hn.ngayHH);
            fwrite.Close();
        }
        public void Update(List<hangNhap> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; i++)
                fwrite.WriteLine(list[i].maHn + "#" + list[i].sLg + "#" + list[i].donGia + "#" + list[i].ngaySX + "#" + list[i].ngayHH);
            fwrite.Close();
        }
    }
}
